import tweepy
import random
import time
import datetime

## Custom Modules
from quoteFetcher import *
from gif_search import *
from tweet_finder import TweetFinder
from initialize_keys import Key_Setup
from bs4 import BeautifulSoup
from tweetassembly import TweetAssembly
from list_builder import List_Builder
from conversation import *


class Main:
    def __init__(self):
        self.assembler = None
        self.list_builder = List_Builder()
        self.conversation = Conversation()
        self.run_assembler()
        # pass

    def tweet_replies(self, times):
        print('Tweeting replies to members of conversationdict...')
        for i in range(times):
            if self.conversation.destroy():
                if i < times-1:
                    self.tiny_entropy

    def initialize_mood(self):
        self.assembler = TweetAssembly()

    def run_assembler(self):
        self.initialize_mood()
        for i in range(3):
            send_message = self.initialize_send_message() ## next(send_message) will send out next tweet
            self.mini_entropy()
            retweet_list_member = self.initialize_retweet_list()
            self.mini_entropy()
            self.refresh_conversation_dict() ## Search for replies to use
            self.mini_entropy()
            self.list_and_follow() ## Add 20 users to random topic list and follow them
            self.mini_entropy()
            #######################initialization of bot 'round' of messages complete##################################################
            self.send_message(send_message, 1) ## Send first topical reply
            self.small_entropy()
            self.tweet_replies(3) ## Reply to three people who have tweeted at us
            self.small_entropy()
            self.retweet_list_member(retweet_list_member) ## First List Member Retweet
            self.small_entropy()
            self.send_message(send_message, 3) ## Send second topical reply
            self.tiny_entropy()
            self.retweet_list_member(retweet_list_member) ## Second List Member Retweet
            self.small_entropy()
            self.send_message(send_message, 2) ## Send third topical reply
            self.tiny_entropy()
            self.refresh_conversation_dict()
            self.mini_entropy()
            self.tweet_replies(2)
            self.small_entropy()
            self.retweet_list_member(retweet_list_member) ## Third List Member Retweet
            self.tiny_entropy()
            self.send_message(send_message, 4)
            self.small_entropy()
            if i == 1:
                self.medium_entropy()
            ###################################long break before it runs again#####################################################
        self.jumbo_entropy()
        self.run_assembler()
    
    def retweet_list_member(self, retweet_list_member):
        try:
            print('Retweeting list member...')
            next(retweet_list_member)
        except:
            pass
    
    def send_message(self, send_message, times):
        try:
            for i in range(times):
                print('Sending message topical reply..')
                next(send_message)
                if i < times-1:
                    self.small_entropy()
        except:
            pass
     
    def list_and_follow(self):
        print('Adding 20 users to random topic list and following...')
        self.list_builder.add_users_to_list()
       
    
    def refresh_conversation_dict(self):
        print('Refreshing conversation dictionary')
        self.conversation.search()
    
    def initialize_retweet_list(self):
        print('Assembling retweet member list')
        retweet_list_member = self.list_builder.retweet_list_tweets()
        return retweet_list_member
     
    def initialize_send_message(self):
        print('Assembling message list')
        send_message =  self.assembler.send_message()
        return send_message

    def mini_entropy(self): 
        #20-40 seconds 
        st = random.randint(20, 40)
        now = self.now()
        sleep_end = now + datetime.timedelta(seconds = st)
        print('Current time: ' + str(now))
        print('Sleep time: ' + str(st))
        print('Next action will begin: ' + str(sleep_end))
        time.sleep(st)
        
        
    def tiny_entropy(self):
        #30-90 seconds 
        st = random.randint(30, 90)
        now = self.now()
        sleep_end = now + datetime.timedelta(seconds = st)
        print('Current time: ' + str(now))
        print('Sleep time: ' + str(st))
        print('Next action will begin: ' + str(sleep_end))
        time.sleep(st)
        
        
    def small_entropy(self):
        #2-4 minutes
        st = random.randint(120, 240)
        now = self.now()
        sleep_end = now + datetime.timedelta(seconds = st)
        print('Current time: ' + str(now))
        print('Sleep time: ' + str(st))
        print('Next action will begin: ' + str(sleep_end))
        time.sleep(st)

    def medium_entropy(self):
        #5-8 minutes
        st = random.randint(300, 480)
        now = self.now()
        sleep_end = now + datetime.timedelta(seconds = st)
        print('Current time: ' + str(now))
        print('Sleep time: ' + str(st))
        print('Next action will begin: ' + str(sleep_end))
        time.sleep(st)

    def large_entropy(self):
        #15-22 minutes
        st = random.randint(900, 1320)
        now = self.now()
        sleep_end = now + datetime.timedelta(seconds = st)
        print('Current time: ' + str(now))
        print('Sleep time: ' + str(st))
        print('Next action will begin: ' + str(sleep_end))
        time.sleep(st)
        
    def jumbo_entropy(self):
        #5-8 hours
        st = random.randint(18000, 28800)
        now = self.now()
        sleep_end = now + datetime.timedelta(seconds = st)
        print('Current time: ' + str(now))
        print('Sleep time: ' + str(st))
        print('Next action will begin: ' + str(sleep_end))
        time.sleep(st)

    def now(self):
        return datetime.datetime.now()

if __name__=="__main__":
    Main()

