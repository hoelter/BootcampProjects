import requests
import random

class Gif_Finder:
    def __init__(self, mood, search_limit):
        self.base_search = "http://api.giphy.com/v1/gifs/search?q="
        self.public_api_key = "&api_key=dc6zaTOxFJmzC"
        self.mood = mood
        self.search_limit = search_limit
     
    def clean_search(self, search):
        search = search.lower().split(' ')
        return '+'.join(search)
    
    def find_gifs(self, search):
        response = requests.get(self.base_search + self.clean_search(search) + self.public_api_key)
        data = response.json()
        gif_list = data['data']
        return [gif['bitly_gif_url'] for gif in gif_list]
        
    def choose_gif(self):
        gif_urls = self.find_gifs(self.mood)
        random_gif = random.choice(gif_urls)
        chance = random.randint(1,2)
        # return random_gif
        if chance == 1:
            return random_gif
        else:
            return ''
