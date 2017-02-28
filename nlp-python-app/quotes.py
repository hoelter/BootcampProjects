import random


class QuoteCaller:

    def __init__(self):
        self.quotes = [

"Bob Ross : No worries. No cares. Just float and wait for the wind to blow you around. Every highlight needs it's own personal shadow. If you don't think every day is a good day - try missing a few. You'll see. There we go. In painting, you have unlimited power. You have the ability to move mountains. You can bend rivers. But when I get home, the only thing I have power over is the garbage.",

"Bob Ross : The only prerequisite is that it makes you happy. If it makes you happy then it's good. But we're not there yet, so we don't need to worry about it. Making all those little fluffies that live in the clouds.",

"Bob Ross : Maybe there's a happy little Evergreen that lives here. See. We take the corner of the brush and let it play back-and-forth. Maybe there's a happy little bush that lives right there.",

"Bob Ross : Isn't it fantastic that you can change your mind and create all these happy things? The light is your friend. Preserve it. We'll take a little bit of Van Dyke Brown.",

"Bob Ross : Automatically, all of these beautiful, beautiful things will happen. This is a happy place, little squirrels live here and play. These things happen automatically. All you have to do is just let them happen.",

"Bob Ross : Just let this happen. We just let this flow right out of our minds. If you do too much it's going to lose its effectiveness. We're not trying to teach you a thing to copy. We're just here to teach you a technique, then let you loose into the world. Just make little strokes like that. When you buy that first tube of paint it gives you an artist license. It's beautiful - and we haven't even done anything to it yet."

]

    def quoteCaller(self):
        quote = random.choice(self.quotes)
        quoteList = quote.rsplit(":")
        print("{0} \n \n        -- {1}".format(quoteList[1], quoteList[0]))


x = QuoteCaller()
print(x.quoteCaller())