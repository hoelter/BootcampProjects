import Wikipedia_API
import cleanrandom


class Detour:
    def __init__(self, title=None):
        self.wiki = Wikipedia_API.Wikipedia_API()
        if title == None:
            self.cr = cleanrandom.Exponentialsearch()
            self.article = self.cr.repeat()
        else:
            self.article = self.wiki.get_article_info(title)
        self.title = self.article['title'].encode('utf-8')
        self.content = self.article['content'].encode('utf-8')
