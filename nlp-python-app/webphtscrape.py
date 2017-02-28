import urllib.request

class Webscraper():
    def __init__(self, search):
        self.html = 0
        self.baseurl = search
        self.listofall = 0
        self.goodlist = 0
        self.endlist = []
        self.badlist = []
        self.main()
        self.content = self.list_to_string()

    def start(self):
        urllink = self.baseurl
        with urllib.request.urlopen(urllink) as url:
            html = url.read()
            self.html = html

    def allfinder(self):
        html = self.html
        html = html.decode().split()

        self.listofall = html

    def filter(self):
        for each in self.listofall:
            # if "\n" in each:
            #     self.badlist.append(each)
            if "\n" in each or "=" in each or "<" in each or ">" in each or "//" in each or "\\\\" in each:
                self.badlist.append(each)
            # elif "<" in each:
            #     self.badlist.append(each)
            # elif ">" in each:
            #     self.badlist.append(each)
            # elif "//" in each:
            #     self.badlist.append(each)
            # elif "\\\\" in each:
            #    self.badlist.append(each)
        self.endlist = [word for word in self.listofall if word not in self.badlist]

    def encoder(self): #take this out if you don't want it to be encoded
        for each in self.endlist:
            each.encode('utf-8')
    
    def list_to_string(self):
        final = ' '.join(self.endlist)
        print(final)
        return final

    def main(self):
        #self.baseurl = input("Enter a webpage url ")
        self.start()
        self.allfinder()
        self.filter()
        #self.encoder()



