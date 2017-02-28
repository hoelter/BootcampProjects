# make a 2 player game (console game), at least 2 player
# involve each player having a set of dice, the dice should be of multiple types
# players should roll dice against each other according to rules you decide
# farkel?
#bonus have optional AI player, persistant high scores, graphics?

import random
import re
import sys
import time
import os
from itertools import combinations

class AI():
    def __init__(self):
        self.total_score = 0
        self.enter_game = False
        ai_flag = True
        
        
    
        
class Player():
    def __init__(self):
        self.total_score = 0
        self.enter_game = False
        self.ai_flag = False
        
        
    
class GameEngine():
    def __init__(self, player_index, total_score):
        self.player_num = player_index + 1
        self.single_value_dict = {1:100, 2:0.1, 3:0.1, 4:0.1, 5:50, 6:0.1}
        self.trip_value_dict = {1:300, 2:200, 3:300, 4:400, 5:500, 6:600, 7:2500}
        self.straight = 1500
        self.three_pairs = 1500
        self.cinq = 2000
        self.quatre = 1000
        self.six = 3000
        self.dice_initial = None
        self.dice = None
        self.round_points = 0
        self.final_round_points = 0
        self.farkle_check_points = 0
        self.enter_game = False
        self.total_score = total_score
        self.ai_flag = False
        self.ai_dice = []
        
                
                
    def check_duplicates(self, dice_list):
        duplicate = set()
        for value in dice_list:
            if value in duplicate or duplicate.add((value)):
                yield value
                
    
    def calculate_duplicates(self):
        dup_list = list(self.check_duplicates(self.dice))
        self.calc_six_dice(dup_list)
        self.calc_five_dice(dup_list)
        self.calc_four_dice(dup_list)
        self.calc_three_dice(dup_list)
    
    def calculate_straight(self):
        if self.farkle_check_points > 0:
            self.farkle_check_points += self.straight
        else:
            self.round_points += self.straight
        
        
    def calculate_singles(self):
        for value in self.dice:
            if self.farkle_check_points > 0:
                self.farkle_check_points += self.single_value_dict[value]
            else:
                self.round_points += self.single_value_dict[value]
                
            
    def calc_six(self, dup_list):
        if len(dup_list) == 5:
            if self.farkle_check_points > 0:
                self.farkle_check_points += self.six
            else:
                self.round_points += self.six
            return True
            
            
    def calc_cinq(self, dup_list):
        if len(dup_list) == 4:
            if self.farkle_check_points > 0:
                self.farkle_check_points += self.cinq
            else:
                self.round_points += self.cinq
            return True
   
    
    def calc_quatre(self, dup_list):
        if len(dup_list) == 3:
            if self.farkle_check_points > 0:
                self.farkle_check_points += self.quatre
            else:
                self.round_points += self.quatre
            return True
            
            
    def calc_triple(self, key, dup_list):
        # if len(dup_list) == 2:
        if len(dup_list) < 3:
            if self.farkle_check_points > 0:
                self.farkle_check_points += self.trip_value_dict[key]
            else:
                self.round_points += self.trip_value_dict[key]
            return True
            
            
    def calc_two_triplets(self):
        if self.farkle_check_points > 0:
            self.farkle_check_points += self.trip_value_dict[7]
        else:
            self.round_points += self.trip_value_dict[7]
        return True
        
                
        
    def calc_three_dice(self, dup_list):
    # calculates 333, 221
        if len(self.dice) == 3:
            if len(dup_list) == 2:
                key = dup_list[0]
                self.calc_triple(key, dup_list)
            else:
                self.calculate_singles()
                
                
    def calc_four_dice(self, dup_list):
    # calculates 4444, 1155, 3331, 2665
        if len(self.dice) == 4:
            if not self.calc_quatre(dup_list):#4444
                try:
                    if dup_list[0] == dup_list[1]:#3331
                        key = dup_list[0]
                        self.calc_triple(key, dup_list)
                        self.update_combo_score(key)
                    else:#1155
                        key0 = dup_list[0]
                        key1 = dup_list[1]
                        if self.farkle_check_points > 0:
                            for i in range(2):
                                self.farkle_check_points += self.single_value_dict[key0]
                                self.farkle_check_points += self.single_value_dict[key1]
                        else:
                            for i in range(2):
                                self.round_points += self.single_value_dict[key0]
                                self.round_points += self.single_value_dict[key1]
                except:#2665
                    self.calculate_singles()

        
    def calc_five_dice(self, dup_list):
    # calculates 55555, 33355, 11115, 33315, 11665
        if len(self.dice) == 5:
            if not self.calc_cinq(dup_list):#55555
                copy_dup = self.dup_again(dup_list)
                if len(copy_dup) == 2:#11115
                    self.calc_quatre(dup_list)
                    calculated = copy_dup[0]
                    self.update_combo_score(calculated)
                elif len(copy_dup) == 1:#33355, 33315
                    key = copy_dup[0]
                    self.calc_triple(key, copy_dup)
                    self.update_combo_score(key)
                else:#11665
                    self.calculate_singles()
            
            
    def calc_six_dice(self, dup_list):
    # calculates 333444, 444455, 555551, 666666, 444451, 551126, 112233, *333221, *222345, *223456
        if len(self.dice) == 6:
            if not self.calc_six(dup_list):#666666
                copy_dup = self.dup_again(dup_list)
                if len(dup_list) == 4:
                    if len(copy_dup) == 2:
                        if copy_dup[0] != copy_dup[1]:#333444
                            self.calc_two_triplets()
                        else:#444455, doesn't use calc_quatre function in this situation
                            key = copy_dup[0]
                            if self.farkle_check_points > 0:
                                self.farkle_check_points += self.quatre
                            else:
                                self.round_points += self.quatre
                            self.update_combo_score(key)
                    else:#555551, doesn't use calc_cinq in this situation
                        if self.farkle_check_points > 0:
                            self.farkle_check_points += self.cinq
                        else:
                            self.round_points += self.cinq
                        calculated = dup_list[0]
                        self.update_combo_score(calculated)
                elif len(dup_list) == 3:#444451, 112233, *333221
                    if len(copy_dup) == 2:#444451
                        key = dup_list[0]
                        if self.farkle_check_points > 0:
                            self.farkle_check_points += self.quatre
                        else:
                            self.round_points += self.quatre
                        self.update_combo_score(key)
                    elif len(copy_dup) == 1:#333221
                        key = copy_dup[0]
                        self.calc_triple(key, copy_dup)
                        self.update_combo_score(key)
                    else:#112233
                        if self.farkle_check_points > 0:
                            self.farkle_check_points += self.three_pairs
                        else:
                            self.round_points += self.three_pairs
                else:#551126, *222345, *223456
                    if len(dup_list) == 2:
                        if dup_list[0] == dup_list[1]:#222345
                            key = dup_list[0]
                            self.calc_triple(key, dup_list)
                            self.update_combo_score(key)
                        else:#551126
                            self.calculate_singles()
                    else:#*223456
                        self.calculate_singles()
     
     
    def update_combo_score(self, calculated):
        dice_copy = self.remove_value(calculated)
        for v in dice_copy:
            if self.farkle_check_points > 0:
                self.farkle_check_points += self.single_value_dict[v]
            else:
                self.round_points += self.single_value_dict[v]
    
    def remove_value(self, value):
        value_removed_list = [val for val in self.dice if val != value]
        return value_removed_list
                       
                
    def dup_again(self, dup_list):
        copy_dup = list(self.check_duplicates(dup_list))
        return copy_dup
             
        
    def calculate_points(self):
        if len(self.dice) > 2 and (len(set(self.dice)) < len(self.dice)):
            self.calculate_duplicates()
        elif len(self.dice) == 6:#123456
            self.calculate_straight()
        else:
            self.calculate_singles()
            
        
    def update_dice(self, choice):
        self.dice = self.dice_initial
        index = ''.join(choice)
        index = index.replace('d', '')
        temp_i = [int(value) for value in index]
        index_list = [value-1 for i, value in enumerate(temp_i)]
        new_dice = []
        for value in index_list:
            new_dice.append(self.dice[value])
        self.dice = new_dice
     
     
    def idiot_proof(self):
        if not isinstance(self.round_points, int):
            print("\nYou've chosen a die worth nothing. Choose again!")
            self.round_points = 0
            time.sleep(4)
            return True

            
    def exact_match(self, choice):
        options = ' d1 d2 d3 d4 d5 d6 '
        verification_ls = []
        for value in choice:
            check = re.compile(r'\b{}\b'.format(value))
            if check.search(options):
                verification_ls.append(0)
            else:
                verification_ls.append(1)
        if 1 not in verification_ls:
            return True
                       
                       
    def initial_farkle_check(self):
        potential = ['d1', 'd2', 'd3', 'd4', 'd5', 'd6']
        slice_length = len(self.dice_initial)
        final = potential[:slice_length]
        self.update_dice(final)
        self.farkle_check_points = .1
        self.calculate_points()
        if self.farkle_check_points > 1:
            self.farkle_check_points = 0
            return True
        else:
            self.farkle_check_points = 0
            return False
        
        
    def choose_die(self):
        while True:
            clear_screen()#global function
            self.round_points = 0
            self.view_dice(self.dice_initial)
            if self.initial_farkle_check():
                print("\n\nWhich die would you like to keep?")
                print("\n\nPlease choose d1-d6 separated by spaces. Example: >>>: d1 d4 d5\nOr, type 'all' to select all.")
                choice = input(">>>: ").lower()
                if choice:
                    choice = choice.split()
                    choice = self.choose_all(choice)
                    if self.exact_match(choice):
                        self.update_dice(choice)
                        self.calculate_points()
                        if not self.idiot_proof():
                            while True:
                                print("\nYour score so far this round is: {}pts".format(self.final_round_points))
                                confirm = input("You've chosen to keep {} worth {}pts.\nIs this correct? 'y' to confirm: ".format(self.choice_display(choice), self.round_points)).lower()
                                if verify_yes_no(confirm) and not self.continued_roll():#global function
                                    if self.final_round_points >= 500:
                                        self.enter_game = True
                                    return True
                                else:
                                    print("Choosing again...\n")
                                    time.sleep(1.5)
                                    break
                    else:
                        print("\rIncorrect format, please use proper format!", end ='')
                        time.sleep(4)
            else:
                self.farkled()
                return True
                
                
    def choose_all(self, choice):
        if choice[0] == 'all':
            new_choice = ["d{}".format(i+1) for i, v in enumerate(self.dice_initial)]
            return new_choice
        else:
            return choice
    
    
    def farkled(self):
        print("\nYou FARKLE! No points this round.\n")
        self.final_round_points = 0
        time.sleep(4)
        
        
    def continued_roll(self):
        self.final_round_points += self.round_points
        self.round_points = 0
        amount_to_roll = len(self.dice_initial) - len(self.dice)
        clear_screen()#global function
        if amount_to_roll == 0:
            amount_to_roll = 6
            print("Total Game Score: {} \t\t(Remember it's 10,000 points to win!))".format(self.total_score))
            print("\nCongrats, you scored on all of your dice, keep going!")
            time.sleep(4)
            clear_screen()
        self.player_display()
        self.view_game_score()
        print("\nYou now have {}pts this round.\nWould you like to roll your remaining {} dice?".format(self.final_round_points, amount_to_roll))
        confirm = input("\nType 'y' to continue rolling or press enter to end your turn: ").lower()
        if verify_yes_no(confirm):#global function
            self.rolldie(amount_to_roll)
            return True
        else:
            return False
            
            
    def player_display(self):
        print("Player {} turn".format(self.player_num).center(80))
        
        
    def initial_roll(self):
        print("\n\nPlayer {} start. Press 'enter' to roll...".format(self.player_num))
        time.sleep(1.3)
        keywait()
        self.rolldie(6)
        
            
    def rolldie(self, amount_to_roll):
        dice = [random.randint(1,6) for i in range(amount_to_roll)]
        self.dice_initial = dice
        
        
    def view_game_score(self): 
        print("Game Score: {}".format(self.total_score))
        
        
    def view_dice(self, roll):
        self.player_display()
        self.view_game_score()
        print("You roll: \n")
        for i, roll in enumerate(roll):
            output= "D{}= {}    ".format(i+1, roll)
            print(output, flush=True)
            #time.sleep(.5)
            
            
    def choice_display(self, choice):
        for value in (choice):
            output = ", ".join(choice).upper()
            return output                           
    
    
    def ai_decision(self):
        combinations = self.ai_calc_poss_choices()
        possible_scores = []
        for dice in combinations:
            self.dice = dice
            self.calculate_points()
            possible_scores.append(self.round_points)
            self.round_points = 0
        score_combo_dict = dict(zip(combinations, possible_scores))
        while True:
            max_point_combination = max(score_combo_dict, key=score_combo_dict.get)
            self.round_points = max_point_combination
            if not self.idiot_proof()
                return 
                
            
            
            
    def ai_score_list(self):
        
        
        
    def ai_calc_poss_choices(self):
        dice = self.dice_initial
        dice_2dtuplists = [list(combinations(dice, i+1)) for i in range(len(dice))]
        unified_tup_list = []
        for ls_of_tup in dice_2dtuplists:
            print(ls_of_tup)
            for tup in (ls_of_tup):
                unified_tup_list.append(tup)
        # print('BREAK')       
        list_of_combination_lists = []
        # print(unified_tup_list)
        for tup in unified_tup_list:
            holder_list = []
            for num in tup:
                holder_list.append(num)
            if holder_list not in list_of_combination_lists:
                list_of_combination_lists.append(holder_list)
            # print(holder_list)
        # print(list_of_combination_lists)
        # print('BREAKBREAKBREAK')
        # for dice_combination in list_of_combination_lists:
            # print(dice_combination)
        combinations = list_of_combination_lists
        return combinations
      
################# Game Engine class ends here #################################
   
def verify_yes_no(verify):
    if verify in ['y', 'yes']:
        return True

def get_winner(winner_comparison):
    scores = list(winner_comparison.values())
    winner_index = list(winner_comparison.keys())
    return winner_index[scores.index(max(scores))]
        
def multiplayer_game(players, amount_player):
    print("\n\n\t\tYou are starting a {} player game!".format(amount_player))
    time.sleep(1)
    print("\n\tRemember, you must score 500 points in one round to get into the game.\n\tUntil then, you will have 0 points.")
    while True:
        end_game_flag = False
        for player_index in range(amount_player):
            current_player = GameEngine(player_index, players[player_index].total_score)
            if players[player_index].total_score >= 10000:
                end_game_flag = True
                break
            current_player.initial_roll()
            current_player.choose_die()
            if current_player.enter_game or players[player_index].enter_game:
                players[player_index].total_score += current_player.final_round_points
                players[player_index].enter_game = True
            else:
                print("\nSorry, you need at least 500 points in one round to enter the game.")
            print("Your updated Game Score is: {}.".format(players[player_index].total_score))
            time.sleep(3.2)
        if end_game_flag == True:
            break
    clear_screen()
    print("Game Over".center(80))
    time.sleep(1.5)
    print("\n\n\t\tAnd the winner is...\n")
    for i in range(160):
        print(".", end='', flush=True)
        time.sleep(.015)
    winner_comparison = {}
    for player_index in range(amount_player):
        winner_comparison.update({player_index: players[player_index].total_score})
    winner = get_winner(winner_comparison)
    print("\n\n\t\tCongratulations Player {}, you win with a score of {}!\n\t\tThanks for playing!\n".format(winner+1, winner_comparison[winner]))
    for player_index, score in winner_comparison.items():
        if player_index != winner:
            print("\t\tPlayer {} score: {}".format(player_index+1, score))
    time.sleep(11)
     
   
def multiplayer_initialize():
    while True:
        try:
            amount_player = int(input("\n\n\t\tHow many people will be playing?: "))
            clear_screen()
            if 1 < amount_player <= 86:
                players = [Player() for i in range(amount_player)]
                return players, amount_player
            else:
                print("\n\n\t\tPlease choose a number between 1 and 86.")
        except:
            clear_screen()
            print("\n\t\tPlease enter a whole number only.")
            
            
            
def quit_game():
    while True:
        verify = input("\n\n\t\tAre you sure you want to quit? 'y' to confirm: " ).lower()
        clear_screen()
        if verify_yes_no(verify):
            print("\n\n\t\tThank you for playing, exiting now...")
            time.sleep(1.3)
            sys.exit()
        else:
            print("\n\n\t\tGoing back...")
            time.sleep(.8)
            break
            
def game_rules(choice):
    if choice == 'rules':
        print("""
Rules of Farkle
--------------------------------------------------------------------------------
OVERVIEW
    Players roll dice for points. You roll six dice, remove only the dice
    that you want to use for points, then re-roll the remaining dice.
    Some scoring dice must be removed after eery roll. If you can eventually
    make all six dice count for score, pick them all up and keep going. If
    none of the dice you roll can count for score, you lose your turn and any
    points you made during the turn.
    
OBJECT OF THE GAME
    To get scoring dice on every roll and be the first player to get
    more than 10,000 points. When one player reaches 10,000pts all other players
    get one more turn to try to beath them.
    
TO GET STARTED
    Each player must first score **at least 500 points** during one turn to get
    into the game.
    
SCORING
    ones= 100pts   fives= 50pts
                COMBOS
    3 ones= 300pts      4 of any kind= 1000pts
    3 twos= 200pts      5 of any kind= 2000pts
    3 threes= 300pts    6 of any kind= 3000pts
    3 fours= 400pts     straight 1-6= 1500pts
    3 fives= 500pts     three pairs= 1500pts
    3 sixes= 600pts     two triplets= 2500pts
    
Press any key to return to the main-menu.
        """)
        keywait()
 
def keywait():
    input("")

def clear_screen():
    os.system("cls")

        
if __name__=="__main__":
    while True:
        clear_screen()
        print("""
        Welcome to the Farkle game!
      
        1) Single Player (currently disabled)
        2) Multiplayer
        3) Rules of Farkle
        Q) Press 'Q' to quit
        """)
        menu_option = input("\t\tWhat would you like to do?: ").lower()
        
        if menu_option == 'q':
            clear_screen()
            quit_game()
        
        # if menu_option == '1':
            # singleplayer()
            
        if menu_option == '2':
            clear_screen()
            players, amount_player = multiplayer_initialize()
            multiplayer_game(players, amount_player)
            
        if menu_option == '3':
            choice = 'rules'
            game_rules(choice)
            
            
            
            
##def singleplayer():
##    while True:
##        try:
##            amount_player = int(input("How many AI players would you like to play?"))
##            if amount_player > 0 or amount_player <= 86:
##                #create number of AI objects
##            else:
##                print("Please choose a number between 1 and 86")
##        except:
##            print("Please enter a whole number only")
        
        
            
