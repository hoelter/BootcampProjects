from initialize_keys import Key_Setup
import tweepy
import random
import pickle


class Conversation():
    def __init__(self):
        self.keys = Key_Setup()
        self.conversationDict = self.read_dict('conversation.txt')
        self.conversation_reference = self.read_dict('reference.txt')
        self.responses= ["Liar","Oh yes oh all knowing wise one.","You are right","You're unbelievable", "I have to say I'm disappointed.","You're extremely sad.","There's both pluses and minuses in most things in life.","You're pathetic","That's one of the advantages we have to match some of the disadvantages we have.","You're Funny.","Absolutely disgraceful.","Stay tuned, you're up for a surprise.","You son of a bitch.","You're an asshole.","I'm a secular humanist","It's going to take some years to repair your reputation.","So I decided to invest some time debunking some of the myths around. It's paid off.","The problem isn't that you think you know, it's that you know you know.","You're wrong.","I'm not quite sure what you're saying?","Do you believe it is 'wrong' to earn any income based on the work of others?","Oh ... my ... god ....","I'm assuming you're clueless, however the way you keep ignoring and dismissing facts that are contrary to your claims indicates that you're perhaps past clueless and actually being deliberately dishonest.","You state as fact something that is demonstrably false.","There is what you believe, and refuse to consider may be mistaken, and there is reality.","No friendship put on the line, right?","Do you think we can be friends?","As you can tell, Twitter is not a place for unicorns","And that's what we get paid for. To tell the story.","I'm seriously considering taking a PhD in the nutrition field","Quite shameful","You are being blatantly dishonest","Wrong.","That statement is 100 percent false","Do you agree with my philosophy?","Completely false.","I almost hate to say this but excellent post.","Go away","HUGGGGGGGE","I hate you.","Sensible advice is good advice.","So, nothing of value to add to the conversation then?","You suck","It takes time and effort to be a Unicorn.","No secret there.","bingo. At least you have that straight.","You're not listening","The earth is flat. Dumbfuck","Make like a tree and go away","Are you satisfied with my intellect?","absurd.","Could you be any more wrong if you tried?"]

    def search(self):
        search_results = self.keys.api.search(q="@FuriousUnicorn1", count=100)
        for tweet_object in search_results:
            user_screen_name = tweet_object.user.screen_name
            tweet_reply = random.choice(self.responses)
            user_screen_name = "@"+user_screen_name
            if tweet_object.id not in self.conversation_reference.keys():
                final_tweet = user_screen_name + " " + tweet_reply
                self.conversationDict.update({tweet_object.id:final_tweet})
                self.conversation_reference.update({tweet_object.id:final_tweet})
        self.save_dict(self.conversationDict, 'conversation.txt')
        self.save_dict(self.conversationDict, 'reference.txt')    
          
    def destroy(self):
        try:
            victim_key_list = [keys for keys in self.conversationDict.keys()]
            victimKey = random.choice(victim_key_list)
            victimMessage = self.conversationDict[victimKey]
            del self.conversationDict[victimKey]
            self.save_dict(self.conversationDict, 'conversation.txt')
            send_tweet = self.keys.api.update_status(status = victimMessage, in_reply_to_status_id = victimKey)
            return True
        except:
            return False
        
    def read_dict(self, name):
        try:
            with open(name +'.pkl', 'rb') as info:
                return pickle.load(info)
        except:
            empty_dict = {}
            return empty_dict
        
    def save_dict(self, obj, name):
        with open (name + '.pkl', 'wb') as target:
            pickle.dump(obj, target, pickle.HIGHEST_PROTOCOL)
    
