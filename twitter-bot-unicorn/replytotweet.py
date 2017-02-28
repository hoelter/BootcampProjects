from initialize_keys import key_setup
import tweepy


class ReplyToTweet(StreamListener):
    def __init__(self):
        self.keys = key_setup()
        
    def on_data(self, data):
        #process stream data here
        
    def on_error(self, status):
        print(status)
        
if __name__=="__main__":
    streamListener=ReplyToTweet()
    twitterStream=Stream(self.keys.auth, r)
    twitterStream.userstream(_with='user')