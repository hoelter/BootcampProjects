from itertools import combinations
from itertools import permutations
import time

# # for item in combinations(range(6), 3):
    # # print(item)
    
# # input =[1, 2, 3, 4, 5, 6]
# # output = sum([map(list, combinations(input, i)) for i in range(len(input) + 1)], [])
# # print(output)


# # input = ['a', 'b', 'c', 'd']

# # output = sum([map(list, combinations(input, i)) for i in range(len(input) + 1)], [])
# # print(output)


# dice = [1,2,3,2]
# # new_list = []
# # for i in range(len(a)):
   # # new_list.append(list(combinations(a,i+1)))
   
# dice_2dtuplists = [list(combinations(dice, i+1)) for i in range(len(dice))] 
# unified_tup_list = []
# for ls_of_tup in dice_2dtuplists:
    # print(ls_of_tup)
    # for tup in (ls_of_tup):
        # unified_tup_list.append(tup)
# # print('BREAK')       
# list_of_combination_lists = []
# # print(unified_tup_list)
# for tup in unified_tup_list:
    # holder_list = []
    # for num in tup:
        # holder_list.append(num)
    # if holder_list not in list_of_combination_lists:
        # list_of_combination_lists.append(holder_list)
    # # print(holder_list)
# print(list_of_combination_lists)
# # print('BREAKBREAKBREAK')
# for dice_combination in list_of_combination_lists:
    # print(dice_combination)
# print(list_of_combination_lists)

combinations = [[1, 2, 3],[1], [3, 6, 5, 2]]
keys_and_index = [i for i, v in enumerate(combinations)]
score_combo_dict = dict(zip(keys_and_index, possible_scores))
while True:
    max_point_score = max(score_combo_dict.values())
    max_point_key = [key for key, value in score_combo_dict.items() if value == max_point_score]
    print('max point key created value is {}'.format(max_point_key))
    self.round_points = max_point_score
    if not self.idiot_proof():
        final_dice = combinations[max_point_key]
        return final_dice
    else:
        del score_combo_dict[max_point_key]

