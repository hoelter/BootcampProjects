from corpus_creation import MrClean
from similarity_query import Query

class Compare:
    def __init__(self, title=None, content=None):
        self.cleaned = MrClean(title, content) #change parameter to 0 when testing with cleanrandom
        self.query = Query(self.cleaned)
        self.query_title = self.query.query_title
        self.top, self.all = self.top_ten()
        
    def display_results(self):
        print(self.query.score_dict)
    
    def top_ten(self):
        ten = sorted(self.query.score_dict.items(), key=lambda x:float(x[1]), reverse=True)
        return ten[:10], ten
        
# if __name__=="__main__":
    # c = Compare()
    # print(c.query_title)
    # for i in c.all:
        # print(i.encode('utf-8'))