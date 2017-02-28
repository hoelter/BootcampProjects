import requests
from bs4 import BeautifulSoup
import random
import re
#import hastag object

class QuoteFetcher:
    def __init__(self, mood='happy'):
        self.url = None
        self.insult = None
        self.pageList = [1,2,3,4,5]
        self.mood = mood
        self.topicList = {
            "funny":"http://www.brainyquote.com/quotes/topics/topic_funny.html",
            "happy":"http://www.brainyquote.com/quotes/topics/topic_happiness.html",
            "sympathy":"http://www.brainyquote.com/quotes/topics/topic_sympathy.html",
            "money":"http://www.brainyquote.com/quotes/topics/topic_money.html",
            "beauty":"http://www.brainyquote.com/quotes/topics/topic_beauty.html",
            "dating":"http://www.brainyquote.com/quotes/topics/topic_dating.html",
            "humor":"http://www.brainyquote.com/quotes/topics/topic_humor.html",
            "sad":"http://www.brainyquote.com/quotes/topics/topic_sad.html",
            "angry":"http://www.brainyquote.com/quotes/topics/topic_anger.html",
            "jealousy":"http://www.brainyquote.com/quotes/topics/topic_jealousy.html",
            "food":"http://www.brainyquote.com/quotes/topics/topic_food.html",
            "intelligence":"http://www.brainyquote.com/quotes/topics/topic_intelligence.html",
            "pets":"http://www.brainyquote.com/quotes/topics/topic_pet.html",
            "relationship":"http://www.brainyquote.com/quotes/topics/topic_relationship.html",
            "movingon":"http://www.brainyquote.com/quotes/topics/topic_movingon.html",
            "society":"http://www.brainyquote.com/quotes/topics/topic_society.html"

            }
        self.quotesList = []
        self.scrapeQuotes()
        
    #Fetch quotes from web
    def scrapeQuotes(self):
        self.url = self.topicList[self.mood]
        r = requests.get(self.url)
        soup = BeautifulSoup(r.content, "html.parser")
        quotes = soup.findAll("a",{"title":"view quote"})
        for quote in quotes:
            self.quotesList.append(str(quote.text))
                
        
    #Return a random quote from list 
    def chooseQuote(self):
        random.shuffle(self.quotesList)
        quote =self.quotesList.pop()
        return quote

    #Call this when you want quotesList cleared and ready for next batch of quotes
    def clearQuotes(self):
        del self.quotesList[:]

    #Scrape web for random insult name
    def addInsult(self):
        url = "http://www.cheezus.com/mean/"
        r = requests.get(url)
        soup = BeautifulSoup(r.content,"html.parser")
        h2 = soup.findAll("h2")
        for insult in h2:
            insult = str(insult).replace("\t","")
            insult = str(insult).replace("<h2>", "")
            insult = str(insult).replace("</h2>","")
            match = re.findall(r"(\b[?\s\w-]+[^\t\n\r])", insult)
            insult = match[0]
            return insult
    
    def quoteDecision(self):
        insult = self.addInsult()
        quote = self.chooseQuote()
        insultDecision = random.randint(1, 3)
        if insultDecision == 1:
            final_quote = quote + ' You ' + insult +'.'
            return final_quote
        else:
            final_quote = quote
            return final_quote






#def HashTagQuotes(self,module.hashtag):
#self.url = ('http://www.brainyquote.com/search_results.html?q=eddie+redmayne')
