import random
import tweepy
import re
import time
from collections import Counter
from initialize_keys import Key_Setup

class List_Builder:
    def __init__(self):
        self.keys = Key_Setup()
        self.topic = self.get_topic()
        self.list_owner = 'FuriousUnicorn1'
        self.list_slug = self.build_list()
        
    def find_tweeters(self, query):
        tweets = self.keys.api.search(query)
        user_id_list = [tweet.user.id for tweet in tweets]
        return user_id_list
        
    def retweet_list_tweets(self):
        tweets = self.keys.api.list_timeline(self.list_owner, self.list_slug)
        tweet_ids = [tweet.id for tweet in tweets][0:5]
        for id in tweet_ids:
            yield self.keys.api.retweet(id)
        
    def get_topic(self):
        file = open("topics.txt", "r+")
        data = file.readlines()
        last_item = data[-1]
        topics = [item[:-2] for item in data if data.index(item) is not len(data) - 1]
        topics.append(last_item)
        return random.choice(topics)
        
    def build_list(self):
        list_name = "{} LOVERS <3".format(self.topic.upper())
        list_description = "Twitterers who can't get enough of {}.".format(self.topic)
        list = self.keys.api.create_list(name=list_name, description=list_description)
        print("List built. List ID: {} | List Slug: {}".format(list.id, list.slug))
        return list.slug
        
    def add_users_to_list(self):
        user_id_list = self.find_tweeters(self.topic)
        random.shuffle(user_id_list) ## Works in Place
        final_list = user_id_list[0:20]
        for id in final_list:
            self.keys.api.add_list_member(user_id=id, slug=self.list_slug, owner_screen_name='@FuriousUnicorn1')
            print("Added {} to {}...".format(id, self.list_slug))