import tweepy
from replykeys import keys


class Key_Setup:
    def __init__(self):
        self.CONSUMER_KEY = keys['consumer_key']
        self.CONSUMER_SECRET = keys['consumer_secret']
        self.ACCESS_TOKEN = keys['access_token']
        self.ACCESS_TOKEN_SECRET = keys['access_token_secret']
        self.auth = tweepy.OAuthHandler(self.CONSUMER_KEY, self.CONSUMER_SECRET)
        self.auth.set_access_token(self.ACCESS_TOKEN, self.ACCESS_TOKEN_SECRET)
        self.api = tweepy.API(self.auth)