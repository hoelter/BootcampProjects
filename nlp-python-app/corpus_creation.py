# import logging
# logging.basicConfig(format='%(asctime)s : %(levelname)s : %(message)s', level=logging.INFO)

import pickle
from gensim import corpora, models, similarities, parsing
from collections import defaultdict
# from nltk.corpus import stopwords
from article_dict import Articles, ObtainQuery

class Corporalize:
    def __init__(self):
        self.art = Articles()
        self.article_dict = self.art.article_dict
        print(len(self.article_dict))
        self.article_titles = []
        self.articles = []
        self.get_title_content()
        # # self.stop_list = self.create_stoplist()
        # # self.cleaned_articles = self.eliminate_stopwords()
        # # self.final_articles = self.eliminate_one_words()
        # self.final_articles = self.process_articles()
        # self.dictionary = self.create_dict_and_save()
        # self.corpus = self.create_corpus_and_save()
        # self.write_titles_articles()
    
    def process_articles(self):
        final_articles = []
        for article in self.articles:
            final_articles.append(parsing.preprocess_string(article))
        return final_articles
        
    # # modify this function when stop list needs to be edited or added to
    # def create_stoplist(self):
        # # stop_list = stopwords.words("english")
        # stop_list += ['==', '===', '====','external', 'links', 'search', '=', 'references', 'summary', '-', '.', ',', '', 'introduction', '^']
        # print(stop_list)
        # pickle.dump(stop_list, open('stoplist.pkl', 'wb'))
        # return stop_list
        
    def write_titles_articles(self):
        pickle.dump(self.article_titles, open('gencache\sftarticle_titles.pkl', 'wb'))
        pickle.dump(self.final_articles, open('gencache\sftarticle_final.pkl', 'wb'))
        
    # def read_stoplist(self):
        # stop_list = pickle.load(open('gencache\stoplist.pkl', 'rb'))
        # return stop_list
       
    # def pre_clean(self, article):
        # clean_all = ['"', "'", ';']
        # text = article.decode('utf-8')
        # for i in clean_all:
            # text = text.replace(i, ' ')
        # return text
        
    # def strip_suffix(self, text, suffix):
        # if text.endswith(suffix):
            # return text[:-len(suffix)]
        # return text
    
    # def eliminate_stopwords(self):
        # cleaned_articles = []
        # for artykle in self.articles:
            # article = self.pre_clean(artykle)
            # art = article.lower().encode('utf-8').split()
            # ls = []
            # for word in art:
                # w = word.decode('utf-8').strip(',.)}{&-(=:!_?').rstrip('s')
                # w = self.strip_suffix(w, 'edit')
                # if w not in self.stop_list:
                    # ls.append(w)
            # cleaned_articles.append(ls)
        # return cleaned_articles
    
    # def eliminate_one_words(self):
        # frequency = defaultdict(int)
        # for article in self.cleaned_articles:
            # for token in article:
                # frequency[token] += 1
        # final_articles = []
        # for article in self.cleaned_articles:
            # ls = [token for token in article if frequency[token] > 1]
            # final_articles.append(ls)
        # return final_articles
        
    def create_dict_and_save(self, fname='gencache\softarticles'):
        dictionary = corpora.Dictionary(self.final_articles)
        dictionary.save(fname + '.dict')
        return dictionary
    
    def create_corpus_and_save(self, fname='gencache\softarticles'):
        corpus = [self.dictionary.doc2bow(article) for article in self.final_articles]
        corpora.MmCorpus.serialize(fname + '.mm', corpus)
        return corpus
    
    def get_title_content(self):
        for title, content in self.article_dict.items():
            try:
                self.article_titles.append(title.decode('utf-8'))
            except:
                self.article_titles.append(title)
            try:
                self.articles.append(content.decode('utf-8'))
            except:
                self.articles.append(content)
            

class MrClean(Corporalize):
    def __init__(self, title, content):
        self.detour = False
        self.title = title
        self.content = content
        if title != None:
            self.detour = True
        self.art = ObtainQuery(self.detour, self.title, self.content) #if detour, pass True
        self.article_dict = self.art.query_dict
        self.article_titles = []
        self.articles= []
        self.get_title_content()
        self.final_articles = self.process_articles()
        
