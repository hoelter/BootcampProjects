#python3 get TypeError: Can't convert 'bytes' object to str implicitly, Works with Python2
import tweepy
from tweepy import Stream
from tweepy.streaming import StreamListener
from initialize_keys import Key_Setup
import json
#override tweepy.StreamListener to add logic to on_status
#import MySQLdb

class listener(StreamListener):
    
    def on_data(self, data):
        all_data = json.loads(data)
        tweet = all_data["text"]
        username = all_data["user"]["screen_name"]
        print((username,tweet))
        print
        return(True)

    def on_error(self, status):
        print(status)
        if status_code == 420:
            return False


keys = Key_Setup()
api = keys.api
auth = api.auth

twitterStream = Stream(auth,listener())
h = twitterStream.filter(track=['tgif'],async = True)
print h



