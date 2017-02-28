## Built-In Modules
import tweepy
import collections
import random

## Custom Modules
from initialize_keys import Key_Setup

class TweetFinder:
    def __init__(self):
        self.keys = Key_Setup()

        
    def find_trending(self):
        locations = [2379574, 2442047, 2436704, 2459115, 2514815]
        location = random.choice(locations)
        hashtag_trends = self.keys.api.trends_place(location)
        hashtags = [x['name'] for x in hashtag_trends[0]['trends'] if x['name'].startswith('#')]
        choice = random.randint(0,2)
        trend_hashtag = hashtags[choice]
        return trend_hashtag
        
        
    def find_tweets(self):
        api = self.keys.api
        hashtag = self.find_trending()
        victims = api.search(q=hashtag,count=50)
        temp = victims[0]
        victim_id_dict = {}
        good_holder = []
        bad_holder = []
        final_victims = []
        for i, obj in enumerate(victims):
            victim_id_dict.update({i: obj.user.id})
        for key, id in victim_id_dict.items():
            if id in good_holder:
                bad_holder.append(key)
            else:
                good_holder.append(id)
        for key in bad_holder:
            del victim_id_dict[key]
        for key in victim_id_dict.keys():
            final_victims.append(victims[key])
        return final_victims, hashtag