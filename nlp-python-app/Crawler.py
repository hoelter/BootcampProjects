from scrapy.spiders.Spider import BaseSpider, CrawlSpider, Rule
from scrapy.selector import HtmlXPathSelector
from scrapy.linkextractors import LinkExtractor
from scrapy.http import Request
import time

class wikiSpider(BaseSpider):
    name = 'wikiSpider'
    allowed_domains = ["wikipedia.org"]
    start_urls = ["http://en.wikipedia.org/wiki/Main_Page"]
    
    rules = (
        Rule(LinkExtractor(restrict_xpaths=('//div[@class="mw-body-content"//a/@href'))),
        Rule(LinkExtractor( allow=("http://en.wikipedia.org/wiki",)),callback="parse_item"),
        )
    
    def parse_item(self, response):
        hxs = HtmlXPathSelector(response)
        #titles = hxs.select('//h1[@class = "firstHeading"]/span/text()').extract()
        #print titles
        content = hxs.select('//table[@id="mp-upper"]/tr')
        #sites = hxs.select('//div[@class="mw-body-content"//a/@href')
        crawledLinks = []
        items = []

        for item in content:
            item = WikipediaItem()
            item['title'] = site.select('.//a/text()').extract()
            #item['link'] = site.select('.//a/@href').extract()
            #item['details'] = site.select('.//p/text()').extract()
            items.append(item)
            print item
        #time.sleep(1)
        #return items

test = wikiSpider()
test.parse_item()