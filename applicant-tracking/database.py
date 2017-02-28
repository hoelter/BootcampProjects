import pymongo
import datetime
from pymongo import MongoClient
import gridfs

class Database:
    def __init__(self):
        self.db = None
        self.cc = None
        self.ec = None
        self.fs = None
        self.setup()
     
    def setup(self):
        client = MongoClient()
        self.db = client.candidate_db
        self.cc = self.db.candidate_collection
        self.ec = self.db.employer_collection
        self.fs = gridfs.GridFS(self.db, collection = 'resume_collection')
        # self.cc.TEXT = 'text' #poss command to index collection, couldn't get to work. I indexed the collections via the mongo.exe environment to allow searching.
        
    def insert_entry(self, entry, flag):
        if flag:
            entry_id = self.ec.insert_one(entry).inserted_id
        else:
            entry_id = self.cc.insert_one(entry).inserted_id
        # return entry_id
        
    def search_text(self, search_term):
        terms = search_term.replace(" or ", " ")
        cc = [candidate for candidate in self.cc.find({'$text': {'$search': terms}})]
        ec = [employer for employer in self.ec.find({'$text': {'$search': terms}})]
        results = cc + ec
        return results
        
    def search_and(self, search_term):
        terms = search_term.split(" and ")
        search1 = "\""+terms[0]+"\" "+ terms[1]
        search2 = "\""+terms[1]+"\" "+ terms[0]
        ec1 = [employer for employer in self.ec.find({'$text': {'$search': search1}})]
        ec2 = [employer for employer in self.ec.find({'$text': {'$search': search2}})]
        cc1 = [candidate for candidate in self.cc.find({'$text': {'$search': search1}})]
        cc2 = [candidate for candidate in self.cc.find({'$text': {'$search': search2}})]
        results1 = ec1 + cc1
        results2 = ec2 + cc2
        try:
            results = [result for result in results1 if result in results2]
            return results
        except:
            return None
        
    def view_all(self):
        candidate_results = self.cc.find({})
        employer_results = self.ec.find({})
        return candidate_results, employer_results
        
    def view_name(self, name):
        return self.cc.find({'Name': name})
        return self.ec.find({'Name': name})
        
    def modify_entry(self, candidate, old_info):
        if candidate.emp_flag:
            result = self.ec.replace_one(old_info, candidate.info)
        else:
            result = self.cc.replace_one(old_info, candidate.info)
    
    def store_resume(self, candidate, old_info):#store in json to turn back into useable object
        if old_info:
            _id = old_info[candidate.mod_key]
            try: 
                self.fs.delete(_id)
            except:
                pass
        _id = self.fs.put(candidate.info[candidate.mod_key])
        candidate.info[candidate.mod_key] = _id
        
    def get_resume(self, candidate):
        input('')
        id = candidate.info[candidate.mod_key]
        resume_object = self.fs.get(id)
        resume = [r for r in resume_object]
        final_res = resume[0].decode('utf8')
        #Not working: switch to storing object as json and decoding from there.
        # r = final_res.encode(ascii)
        # print(r)
        print(final_res)
        return final_res
        