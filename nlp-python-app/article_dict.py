# try:
from DAO import *
# except:
    # pass
from detour import Detour
import pickle
import re

class Articles:
    def __init__(self):
        self.article_dict = self.load_article_dict()

    def read(self):
        dao = DAO()
        articles = dao.find("random")
        for article in articles:
            title = article["title"]
            content = article["content"]
            cont = content.encode('utf-8')
            self.article_dict.update({title:cont})

    def save_article_dict(self):
        pickle.dump(self.article_dict, open("gencache/article_dict.pkl", "wb"))

    def load_article_dict(self):
        article_dict = pickle.load(open("gencache/article_dict.pkl", "rb"))
        return article_dict
        
        
class ObtainQuery(Articles):
    def __init__(self, detour, title, content):
        self.detour = detour
        self.title = title
        self.query_dict = self.get_query()
		
    def get_query(self):
        if not self.detour:
            blank = ''.encode('utf-8')
            content = blank
            dao = DAO()
            while content == blank:
                article = dao.pop('random')
                title = article["title"]
                content = article["content"].encode('utf-8')
            query = {title:content}
            return query
        else:
            return self.get_detour()
            
    def get_detour(self):
        if self.content != None:
            pass
        elif self.title == 0:
            d = Detour()
        else:
            d = Detour(self.title)
        try:
            query = {d.title:d.content}
        except:
            query = {self.title:self.content}
        return query
        
