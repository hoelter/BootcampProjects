from Wikipedia_API import Wikipedia_API
from DAO import *

class article_handler:
	def __init__(self):
		self.DAO = DAO()
		self.wikipedia = Wikpedia_API()
		self.db_count = 0
	
	def fetch_documents(self):
		random_title = self.wikipedia.get_random(1,[],0)
		new_article = self.wikipedia.get_article_info(random_title)
		self.DAO.insert_one(new_article, "new_articles")

	def update_database(self):
		count = self.DAO.count("new_articles")
		if count < 20:
			self.fetch_documents()




