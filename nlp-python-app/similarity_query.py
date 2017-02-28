# import logging
# logging.basicConfig(format='%(asctime)s : %(levelname)s : %(message)s', level=logging.INFO)

import pickle
from gensim import corpora, models, similarities

class Similarity:
    def __init__(self, dictpath='gencache\softarticles.dict', corpuspath='gencache\softarticles.mm'):
        self.article_titles = self.load_article_titles()
        self.dictionary = self.load_corp_dict(dictpath)
        self.corpus = self.load_corpus(corpuspath)
        # self.lsi = self.create_lsi()   
        # self.index = self.create_sim_index('gencache\sftarticle')
        
    def create_sim_index(self, fname):
        index = similarities.MatrixSimilarity(self.lsi[self.corpus])
        index.save(fname + '.index')
        return index
        
    def load_corpus(self, corpuspath):
        corpus = corpora.MmCorpus('{}'.format(corpuspath))
        return corpus
        
    def load_corp_dict(self, dictpath):
        dict = corpora.Dictionary.load('{}'.format(dictpath))
        return dict
        
    def create_lsi(self):
        lsi = models.LsiModel(self.corpus, id2word=self.dictionary, num_topics=50)
        lsi.save('gencache\sftartlsi')
        return lsi
        
    def load_index(self):
        index = similarities.MatrixSimilarity.load("gencache\sftarticle.index")
        return index
        
    def load_lsi(self):
        lsi = models.LsiModel.load('gencache\sftartlsi')
        return lsi
        
    def load_article_titles(self):
        article_titles = pickle.load(open('gencache\sftarticle_titles.pkl', 'rb'))
        return article_titles
        
   
        
class Query(Similarity):
    def __init__(self, Mrclean, dictpath='gencache\softarticles.dict'):
        self.query = Mrclean.final_articles
        self.query_title = Mrclean.article_titles
        self.article_titles = self.load_article_titles()
        self.dictionary = self.load_corp_dict(dictpath)
        self.lsi = self.load_lsi()
        self.index = self.load_index()
        #Necessary objects to perform the query are now loaded; below comparison is made
        self.vec_lsi = self.create_query(self.query)
        self.sims = self.perform_query()
        self.score_dict = self.match_title_score()
        
    def create_query(self, qlist):
        query = qlist[0]
        vec_bow = self.dictionary.doc2bow(query)
        vec_lsi = self.lsi[vec_bow]
        return vec_lsi
        
    def perform_query(self):
        sims = self.index[self.vec_lsi]
        return sims
        
    def match_title_score(self):
        score_dict = {}
        for i, v in enumerate(self.sims):
            title = self.article_titles[i]
            value = (float(v)+1)*1000/2-500
            value = str(value)[:5]
            score_dict.update({title:value})
        return score_dict
