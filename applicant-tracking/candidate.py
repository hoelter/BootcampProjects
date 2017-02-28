import os
import time
from pdfrw import PdfReader, PdfWriter
#custom modules
from menu import Menu
from database import Database

class Candidate:
    def __init__(self, info = {
          'Name': None
        , 'Address': None
        , 'Skills': None
        , 'Notes': None
        , 'Interview Notes':None
        , 'Job Offers':None
        # , 'Resume':None #currently broken, can't store the resume info in database
        }):
        self.info = info
        self.func_mappings = {
          'Name':self.get_name
        , 'Address':self.get_address
        , 'Skills':self.get_skills
        , 'Notes':self.get_notes
        , 'Interview Notes':self.get_interview_notes
        , 'Job Offers':self.get_job_offers
        # , 'Resume':self.get_resume
        }
        self.emp_flag = False
        self.entry_id = None
        self.mod_key = None
        self.mod_value = None
        self.file_name = None
        self.controller = Database()
        
    def get_name(self):
        while True:
            Menu.clear_screen()
            if self.emp_flag:
                name = input("Please input the employer name: ").title()
            else:
                name = input("Please input the candidate name: ").title()
            print("The name you have entered is: {}".format(name))
            verify = input("Is this correct? 'y' to confirm: ").lower()
            if Menu.verify_yes_no(verify):
                self.info['Name'] = name
                break
        
    def get_address(self):
        while True:
            Menu.clear_screen()
            if self.emp_flag:
                address = input("Please input the employer address: ")
            else:
                address = input("Please input the candidate address: ")
            print("The address you have entered is: {}".format(address))
            verify = input("Is this correct? 'y' to confirm: ").lower()
            if Menu.verify_yes_no(verify):
                self.info['Address'] = address
                break
    
    def get_skills(self):
        while True:
            Menu.clear_screen()
            if self.emp_flag:
                skills = input("Please input any specific skills the employer is looking for separated by a ',' each:\n>>> ")
            else:
                skills = input("Please input any specific skills the candidate has separated by a ',' each:\n>>> ")
            print("The skills you have entered are:\n{}".format(skills))
            verify = input("Is this correct? 'y' to confirm: ").lower()
            if Menu.verify_yes_no(verify):
                self.info['Skills'] = skills
                break
    
    def get_interview_notes(self):
        self.mod_key = "Interview Notes"
        choice = None
        while choice != 'q':
            Menu.clear_screen()
            print("\nEnter interview notes in text editor. Save the file when finished.")
            time.sleep(2)
            self.open_data()
            choice = input("\n\t\tPlease type 'done' when finished.\n>>>> ").lower().strip()
            if choice == 'done':
                new_value = self.save_data()
                print("The interview notes you have entered are:\n{}".format(new_value))
                verify = input("Is this correct? 'y' to confirm: ").lower()
                if Menu.verify_yes_no(verify):
                    print("\nEntry complete and saving now.")
                    self.info[self.mod_key] = new_value
                    choice = 'q'
                    time.sleep(2)
    
    def get_notes(self):#input longer than one line doesn't work
        self.mod_key = "Notes"
        choice = None
        while choice != 'q':
            Menu.clear_screen()
            print("\nEnter notes in text editor. Save the file when finished.")
            time.sleep(2)
            self.open_data()
            choice = input("\n\t\tPlease type 'done' when finished.\n>>>> ").lower().strip()
            if choice == 'done':
                new_value = self.save_data()
                print("The notes you have entered are:\n{}".format(new_value))
                verify = input("Is this correct? 'y' to confirm: ").lower()
                if Menu.verify_yes_no(verify):
                    print("\nEntry complete and saving now.")
                    self.info[self.mod_key] = new_value
                    choice = 'q'
                    time.sleep(2)
                
    def get_job_offers(self):
        while True:
            Menu.clear_screen()
            if self.emp_flag:
                job_offers = input("Please input any information on job offers the employer has available:\n>>> ")
            else:
                job_offers = input("Please input any information on job offers the candidate has received:\n>>> ")
            print("The job offer information you have entered is:\n{}".format(job_offers))
            verify = input("Is this correct? 'y' to confirm: ").lower()
            if Menu.verify_yes_no(verify):
                self.info['Job Offers'] = job_offers
                break
            
    def get_resume(self):
        while True:
            Menu.clear_screen()
            location = input("Please attach the candidate resume by specifying the file path with a .pdf ending: ")
            print("The file path for the candidate's resume is: {}".format(location))
            verify = input("Is this correct? 'y' to confirm: ").lower()
            if Menu.verify_yes_no(verify):
                resume = self.save_resume(location)
                self.info['Resume'] = resume
                break
                
    #integrate resume into modify/update function
    def save_resume(self, resume):
        document = PdfReader(resume).pages
        return document
        
        
    def open_resume(self, resume):
        r = PdfWriter()
        r.addpages(resume)
        pdf_name = self.info["Name"] + ".pdf"
        r.write(pdf_name)
        os.system("start " + pdf_name)
        
    def open_data(self):#open data and edit in txt file
        file_name = self.mod_key.replace(" ", "")
        self.file_name = file_name +'.txt'
        with open(self.file_name, 'w+') as file:
            file.write(str(self.mod_value))
        os.system("start " + self.file_name)
        
    def save_data(self):
        with open(self.file_name, 'r+') as file:
            value = file.read()
        os.system("del " + self.file_name)#auto deletes file after saving into value
        return value
            
    def get_modification(self):#integrate options, perhaps send to 'get' functions and change those to file mods
        choice = None
        resume = False
        while choice != 'q':
            if self.mod_key == "Resume":
                # if self.mod_value != None:
                    # print("\n\t\tHere is the current resume.")
                    # resume = self.controller.get_resume(self)
                    # self.open_resume(resume)
                # choice = input("Please enter the new resumes file path\nand file name with a .pdf ending: ")
                # resume = self.save_resume(choice)
                # new_value = choice
                print("\n\t\tResume saving inside database is currently malfunctioning, pick another option please.")
                time.sleep(4)
                break
            else:
                print("\n\t\tYou have chosen to modify '{}'.\n".format(self.mod_key))
                print("\nOpening contents in text editor. Please modify and save the file.")
                self.open_data()
                new_value = None
            choice = input("\n\t\tPress enter to continue when ready...")
            if not new_value:
                new_value = self.save_data()
            Menu.clear_screen()
            print("\nThe information you have entered is:\n{}".format(new_value))
            verify = input("Is this correct? 'y' to confirm: ").lower()
            if Menu.verify_yes_no(verify):
                print("\nEntry complete and saving now.")
                if resume:
                    self.info[self.mod_key] = resume.encode('utf8')
                else:
                    self.info[self.mod_key] = new_value
                choice = 'q'
                time.sleep(2)
                return resume

  
class Employer(Candidate):
    def __init__(self, info = {
          'Name': None
        , 'Address': None
        , 'Skills': None
        , 'Notes': None
        , 'Interview Notes':None
        , 'Job Offers':None
        #, 'Resume':None
        }):
        self.info = info
        self.func_mappings = {
          'Name':self.get_name
        , 'Address':self.get_address
        , 'Skills':self.get_skills
        , 'Notes':self.get_notes
        , 'Interview Notes':self.get_interview_notes
        , 'Job Offers':self.get_job_offers
        # , 'Resume':self.get_resume
        }
        self.emp_flag = True
        self.entry_id = None
        self.mod_key = None
        self.mod_value = None
        self.file_name = None
        
    