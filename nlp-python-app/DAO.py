import pymongo
from pymongo import MongoClient
from keys import keys

class DAO:
    def __init__(self):
        self.connection = MongoClient(keys['SERVER'])
        self.handle = self.connection[keys['DATABASE']]
        self.handle.authenticate(keys['USER_NAME'], keys['PASSWORD'])
    
    def insert_one(self, entry, collection):
        id = self.handle[collection].insert_one(entry).inserted_id
        return id
    
    def find(self, collection, key=None):
        cursor = self.handle[collection].find()
        return cursor
        # return [item[key] for item in cursor]
        
    def pop(self, collection):
        cursor = self.handle[collection].find()
        next_item = cursor.next()
        self.handle[collection].delete_one({'title': next_item['title']})
        return next_item

    def count(self, collection):
        n = self.handle[collection].count()
        return n
