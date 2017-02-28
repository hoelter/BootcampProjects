import os,sys
from random import *
from Wikipedia_API import *
from DAO import *
import load

class Trainingset:
    def __init__(self):
        self.DAO = DAO()
        self.api = Wikipedia_API()
        self.links = self.read_file("links.txt")
        ## self.random = self.api.get_random(10, [], 0)
        
    def annotate(self, input):
        print("Beginning annotation of {} titles.".format(len(input)))
        inserted = 0
        for title in input:
            try:
                page_info = self.api.get_article_info(title)
                inserted_id = self.DAO.insert_one(page_info, "topics")
                print("Inserted: {}".format(inserted_id))
                inserted += 1
            except Exception as e:
                print(e)
        print("Inserted: {} article objects.".format(inserted))
            
    def test(self, input):
        successfully_parsed = 0
        errored_out = []
        for title in input:
            try:
                page_info = self.api.get_article_info(title)
                if page_info['links'] is not None:
                    successfully_parsed += 1
                    print("Parsed {}".format(title))
            except Exception as e:
                print(e)
                errored_out.append(title)
                
        return successfully_parsed, errored_out
            
    def read_file(self, file):
        file = open('links.txt', 'r+')
        lines = file.readlines()
        file.close()
        return [line[:-1] for line in lines]
        
set = Trainingset()
titles = pickle.load(open('picklejar.pkl', 'rb'))
set.annotate(titles)