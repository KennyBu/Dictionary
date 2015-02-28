# Dictionary

Given a dictionary of words
And user entered word to compare against
When comparing the given word against the dictionary
Then output all words in the dictionary that exist in the given word

E.g. StartBurst would output Star and Burst if those words were in the dictionary.

Assumptions

- The Dictionary will contain the following words: "Star","Burst","Car","House","Programming","Test".

- If the user does not enter a search expression in the command line the default search will be "StartBurst".

- The search is case sensitive.
