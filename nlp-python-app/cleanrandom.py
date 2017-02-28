import urllib.request
import wikipedia
import time, random
from Wikipedia_API import *
# from DAO import *

class Exponentialsearch():
    def __init__(self):
        # self.DAO = DAO()
        self.wikipedia = Wikipedia_API()
        self.searcheachpage = 0
        self.keywordlist = 0
        self.html = 0
        self.titlehtml = 0
        self.gettitle = 0
        self.geturl = 0
        self.listofwords = 0
        self.alllinks = 0
        self.getpage = 0
        self.tags = 0
        self.hreflist = 0
        self.badfilter = 0
        self.goodfilter = 0
        self.filtered = 0
        self.baseurl = "https://en.wikipedia.org"
        self.basesearch = "Feces"
        self.linkforwiki = 0
        self.listoftitles = 0
        self.displaytitle = 0
        self.titlenumber = 0
        self.totallinkslist = 0
        self.totalgoodlinks = []
        self.userstart()

    def start(self, searchexact):
        getpage = wikipedia.page(searchexact)
        self.gettitle = getpage.title
        self.geturl = getpage.url

        urllink = self.geturl
        with urllib.request.urlopen(urllink) as url:
            html = url.read()
            self.html = html
            self.titlehtml = html

    def continuesearch(self, nextlink):
        getpage = wikipedia.page(nextlink)
        self.gettitle = getpage.title
        self.geturl = getpage.url

        urllink = self.geturl
        with urllib.request.urlopen(urllink) as url:
            html = url.read()
            self.html = html
            self.titlehtml = html

    def findhref(self):#html
        html = self.html
        html = html.decode().split("<a href=\"")#
        tags = []
        listofwords = []

        for foreachhref in html:
            tags.append(foreachhref)

        for eachitem in tags:
            cuthalf = eachitem.split("\"")#
            listofwords.append(cuthalf)
            self.listofwords = listofwords

    def titlemaker(self):
        html = self.titlehtml
        html = html.decode().split("title=\"")
        tags = []
        listoftitles = []

        for eachtitle in html:
            tags.append(eachtitle)

        for eachitem in tags:
            cuthalf = eachitem.split("\"")
            listoftitles.append(cuthalf)
            self.listoftitles = listoftitles

    def retreivefirst(self):
        hreflist = []
        for eachlist in self.listofwords:
            hreflist.append(eachlist[0])
        self.hreflist = hreflist

    def retreivefirsttitle(self):
        titlelist = []
        title = []
        for eachlist in self.listoftitles:
            titlelist.append(eachlist[0])

        encode = [x.encode('utf-8') for x in titlelist]
        self.displaytitle = encode

    def randomtitle(self):
        length = len(self.displaytitle)

        self.titlenumber = random.randint(10, length)

    def filterlinks(self):
        self.badfilter = []
        for eachlink in self.hreflist:
            if "\n" in eachlink:
                self.badfilter.append(eachlink)
            if "\t" in eachlink:
                self.badfilter.append(eachlink)
            if "#" in eachlink:
                self.badfilter.append(eachlink)
            if " " in eachlink:
                self.badfilter.append(eachlink)

        self.goodfilter = list(set(self.hreflist) - set(self.badfilter))

    def wikilinker(self):
        linkforwiki = []
        for eachlink in self.goodfilter:
            newurl = self.baseurl + eachlink
            linkforwiki.append(newurl)
            self.linkforwiki = linkforwiki

    def totallinks(self):
        links = self.displaytitle
        self.totalgoodlinks += links
        self.totalgoodlinks = list(set(self.totalgoodlinks))

    def userstart(self):
        # input("Hit enter to start")
        self.start(self.basesearch)
        self.main()
        self.repeat()


    def main(self):
        self.findhref()
        self.retreivefirst()
        self.filterlinks()
        self.wikilinker()
        self.titlemaker()
        self.retreivefirsttitle()
        self.randomtitle()

    def newmain(self, nextlink):
        self.continuesearch(nextlink)
        self.findhref()
        self.retreivefirst()
        self.filterlinks()
        self.titlemaker()
        self.retreivefirsttitle()
        self.randomtitle()

    def repeat(self):
        exit = False
        while exit != True: #this number should never hit 0, so you need to breka the loop somehow
            try:
                time.sleep(1.0)
                self.randomtitle()
                self.basesearch = self.displaytitle[self.titlenumber]
                # print("Title (encoded in utf-8): ", self.basesearch)
                new_article = self.wikipedia.get_article_info(self.basesearch.decode('utf-8'))
                if new_article['title'] == None or new_article['content'] == None:
                    raise SyntaxError
                exit = True
                return new_article
                # while True:
                    # time.sleep(0.1)
                    # count = self.DAO.count("new_articles")
                    # if count >= 20:
                        # pass
                    # else:
                        # self.DAO.insert_one(new_article,"new_articles")
                        # return False
            except:
                exit = False
                # time.sleep(.5)
                # self.repeat() #this will just repeat the function if it runs into an error
                # continue





