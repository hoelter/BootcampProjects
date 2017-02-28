import os
import time
import sys
#Project modules
import database
from candidate import *

class Menu:
    def __init__(self):
        self.controller = database.Database()
        self.old_info = None
        self.emp_flag = False
        self.display_main_menu()

    @staticmethod
    def verify_yes_no(verify):
        if verify in ['y', 'yes']:
            return True
             
    @staticmethod   
    def clear_screen():
        os.system("cls")
        
    def quit(self):
        while True:
            self.clear_screen()
            verify = input("\n\n\t\tAre you sure you want to quit? 'y' to confirm: " ).lower()
            self.clear_screen()
            if self.verify_yes_no(verify):
                print("\n\n\t\tExiting now...")
                time.sleep(1.3)
                sys.exit()
            else:
                print("\n\n\t\tGoing back...")
                time.sleep(.8)
                break
        
    def display_main_menu(self):
        while True:
            self.emp_flag = False
            self.clear_screen()
            print("""
        Welcome to Hoelter's Applicant Tracking Software
               
        1) Search database
        2) Add or modify candidate/employer
        
        q) Quit
            """)
            menu_option = input("\t\tWhat would you like to do?: ").lower().strip()
            if menu_option == 'q':
                self.quit()
            elif menu_option == '1':
                self.search_database()
            elif menu_option == '2':
                self.add_modify()
                
    def search_database(self):#Results are displayed now...but access from here? integrate better program flow
        self.clear_screen()
        search_term = None
        while search_term != 'q':
            search_term = input("Please enter your search terms separated by spaces.\nYou can also search using the word 'or' and 'and' in between keywords. Enter 'q' to go back.\n")
            if 'or' in search_term:
                terms = search_term.replace("or", "")
                results = self.controller.search_text(terms)
            elif 'and' in search_term:
                results = self.controller.search_and(search_term)
            else:
                results = self.controller.search_text(search_term)
            for result in results:
                for key, value in result.items():
                    if key != '_id':
                        print('{}: {}'.format(key, value))
                            
    def modify_menu(self):
        self.clear_screen()
        choice = None
        while choice != 'q':
            print("""
        1) View all
        2) Specify by name (disabled)
        
        q) Go back
            """)
            choice = input("\n\t\tWhat would you like to do?: ").lower().strip()
            if choice == '1':
                self.view_all()
            # elif choice == '2':
                # self.view_by_name()#need to write function

    def view_by_name(self):
        pass
        
    def view_all(self):#refresh single choice, search by name to do so?
        choice = None
        while choice != 'q':
            self.clear_screen()
            c_docs, e_docs = self.controller.view_all()
            if self.emp_flag:
                docs = [doc for doc in e_docs]
                title = "Employers\n"
            else:
                docs = [doc for doc in c_docs]
                title = "Candidates\n"
            names = [document['Name'] for document in docs]
            print(title.center(80))
            for i, name in enumerate(names):
                print("\t{}: {}".format((i+1), name))    
            choice = input("\n\nEnter 'q' to go back at anytime.\nEnter the corresponding number for the candidate or employer you wish to modify here: ").lower().strip()
            if choice != 'q':
                try:
                    choice = int(choice)
                    if 0 < choice <= len(docs):
                        self.old_info = docs[choice-1]
                        self.choose_entry()
                    else:
                        raise SyntaxError("There is no error /wave hand.")
                except:
                    print("Please enter a valid number.")
                    time.sleep(4)
        
    def choose_entry(self):
        self.clear_screen()
        info = self.old_info.copy()
        choice = None
        keys = []
        values = []
        if self.emp_flag:
            c = Employer(info)
        else:
            c = Candidate(info)
        _id = info.pop("_id")
        for key, value in info.items():
            keys.append(key)
            values.append(value)
        while choice != 'q':
            for i, key in enumerate(keys):
                if values[i] == None:
                    v = 'None'
                else:
                    v = str(values[i])
                if len(v) > 25:
                    v = v[:25]
                    print("{}) {}: {}...".format(i+1, key, v))
                else:
                    print("{}) {}: {}".format(i+1, key, v))
            choice = input("Which entry would you like to modify: ").lower().strip()
            if choice != 'q':
                try:
                    choice = int(choice)
                    if 0 < choice <= len(values):
                        c.mod_key = keys[choice-1]
                        c.mod_value = values[choice-1]
                        resume = c.get_modification()
                        if resume:
                            self.controller.store_resume(c, self.old_info)
                        self.controller.modify_entry(c, self.old_info)
                        break
                    else:
                        raise SyntaxError("Not a valid number---")
                except:
                    print("Please enter a valid number.")
                    time.sleep(4)
                    self.clear_screen()
            
    def add_modify(self):
        self.clear_screen()
        choice = None
        while choice != 'q':
            print("""
        Would you like to add a new candidate or employer?
        1) Add new Candidate
        2) Add new Employer
        3) Modify existing Candidate
        4) Modify existing Employer
        
        q) Return to the main-menu
                """)
            choice = input("\n\t\tWhat would you like to do?: ").lower().strip()
            if choice == '1':
                self.add_candidate()
            elif choice == '2':
                self.emp_flag = True
                self.add_candidate()
            elif choice == '3':
                self.modify_menu()
            elif choice == '4':
                self.emp_flag = True
                self.modify_menu()
            self.emp_flag = False
            
    def add_candidate(self):
        self.clear_screen()
        if self.emp_flag:
            c = Employer()
        else:
            c = Candidate()
        c.get_name()
        choice = None
        while choice != 'q' and choice != 'd':
            self.clear_screen()
            print("\t\tWhat information would you like to add for {}?".format(c.info['Name']))
            options = [key for key, value in c.info.items() if not value]
            for i, key in enumerate(options):
                print("\t\t{}) {}".format(i+1, key))
            print("\t\t{}) Show current information".format(len(options)+1))
            print("\n\t\td) Complete Entry")
            print("\t\tq) Cancel Entry\n")
            choice = input("What would you like to do: ").lower().strip()
            if choice == 'd':
                self.controller.insert_entry(c.info, c.emp_flag)
            elif choice == (str(len(options)+1)):
                print(c.info)#make prettier
            else:
                try:
                    key = options[int(choice)-1]
                    c.func_mappings[key]()
                except:
                    continue
            
            
if __name__=="__main__":
    Menu()
            
            
            
    