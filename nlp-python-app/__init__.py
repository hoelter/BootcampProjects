from flask import Flask, render_template, redirect, request, url_for
import os
import sys, traceback
from run_comparison import Compare
from webphtscrape.py import *

app = Flask(__name__)

@app.route('/index', methods = ['GET'])
@app.route('/', methods = ['GET'])
def index():
    try:
        return render_template('index.html')
    except Exception as e:
        traceback(e)
        
@app.route('/training-set', methods = ['GET', 'POST'])
def training_set():
    try:
        ## titles = dao.find('topics', 'title')
        ## titles = [title.title() for title in titles]
        return render_template('training-set.html')
    except Exception as e:
        traceback(e)
    
@app.route('/search', methods = ['POST'])
def search():
    try:
        search = request.form['search']
        scraper = Webscraper(search)
        content = scraper.content
        comparison = Compare(search, content)
        context = {'searched': True, 'query_name': comparison.query_title[0], 'results': comparison.top}
        return render_template('index.html', **context)
    except Exception as e:
        return render_template('index.html', error = True)

@app.route('/quote')
def quote():
    try:
        return render_template('quote.html')
    except Exception as e:
        traceback(e)
    
def traceback(e):
    ex_type, ex, tb = sys.exc_info()
    traceback.print_tb(tb)
    print("Error: {} | Type: {}".format(e, type(e)))

if __name__ == '__main__':
    app.run()