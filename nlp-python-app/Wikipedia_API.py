import requests
import wikipedia
import pickle
from urllib import parse

class Wikipedia_API():
    def __init__(self):
        self.endpoint = "http://en.wikipedia.org/w/api.php"
        self.article_constructor = "&format=json&action=query&prop=revisions&rvprop=content"
        self.random_constructor = "&action=query&list=random&rnredirect=true&format=json"
            
    def get_article_info(self, title, auto_suggest = True, redirect = True):
        try:
            title = str(title)
            page = wikipedia.page(title = title, auto_suggest = auto_suggest, redirect = redirect)
            page_info = {
                'title': page.title,
                'url': page.url,
                'page_id': page.pageid,
                'content': page.content,
                'summary': page.summary,
                'links': page.links,
                ## 'json': self.get_article_json(title),
            }
            return page_info
        except Exception as e:
            print("Type: {} | Error: {}".format(type(e), e))
        
    def get_article_json(self, title):
        title = parse.quote_plus(title)
        response = requests.get(self.endpoint + "?titles={}".format(title) + self.article_constructor)
        return response.json()
        
    def search_topical(self, file_name):
        old_file = open('links.txt', 'r+')
        old_lines = old_file.readlines()
        old_titles = [title[:-1] for title in old_lines]
        old_file.close()
        output = []
        for idx, link in enumerate(old_titles):
            try:
                related = wikipedia.search(link)
                for item in related:
                    output.append(item)
                print("Fetched and added search contents to output. Remaining: {}".format(len(old_titles) - (idx + 1)))
            except Exception as e:
                print(e)
        pickle.dump(output, open("picklejar.pkl", 'wb'))
        
    def get_random(self, num, output, missed):
        print("Starting to obtain {} random articles".format(num))
        response = requests.get(self.endpoint + "?rnlimit={}".format(str(num)) + self.random_constructor)
        article_titles = [article['title'] for article in response.json()['query']['random']]
        output = output
        missed = missed
        for title in article_titles:
            try:
                page = wikipedia.page(title = title)
                output.append(page.title)
                print("Successfully fetched {}".format(title))
            except Exception as e:
                missed += 1
                print("Error Fetching {}".format(title))
                print(type(e))
                pass
        if missed > 0:
            return self.get_random(missed, output, 0)
        return output