import tweepy
import random
import time

## Custom Modules
import datetime
from quoteFetcher import *
from gif_search import *
from tweet_finder import TweetFinder
from initialize_keys import Key_Setup
from bs4 import BeautifulSoup

class TweetAssembly:
    def __init__(self):
        self.keys = Key_Setup()
        self.hashtag = None
        self.mood = self.get_mood()
        self.giffer = Gif_Finder(self.mood, 50)
        self.quoter = QuoteFetcher(self.mood)
        self.search_results = None
        self.set_search_hashtag()
    
    
    def set_search_hashtag(self):
        finder = TweetFinder()
        search_results, hashtag = finder.find_tweets()
        self.search_results = search_results
        self.hashtag = hashtag
    
    
    def send_message(self):
        for tweet in self.search_results:
            message = self.assemble_message()
            recipient_sn = tweet.user.screen_name
            final_tweet = "@{}, {} {}".format(recipient_sn, message, self.hashtag)
            if len(final_tweet) <= 140:
                print(final_tweet)
                yield self.keys.api.update_status(status = final_tweet, in_reply_to_status_id = tweet.id)
            
            
    def assemble_message(self):
        message_text = self.quoter.quoteDecision()
        message_gif = self.giffer.choose_gif()
        final_message = message_text + '\n' + message_gif
        return final_message
        
        
    def get_mood(self):
        mood_options = ['funny', 'happy', 'sympathy', 'money', 'beauty', 'dating', 'humor', 'sad', 'angry', 'jealousy', 'food', 'intelligence', 'pets', 'relationship', 'movingon', 'society']
        mood = random.choice(mood_options)
        return mood
        
        