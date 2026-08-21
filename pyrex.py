import re

mynumber = "my number is 415-555-4242"
phonNumRegex = re.compile(r'(\d\d\d)-(\d\d\d-\d\d\d\d)')
mo = phonNumRegex.search(mynumber)
if mo:
    print('Phone number found: ' + mo.group(0))
    print('Area code: ' + mo.group(1))
    print('Main number: ' + mo.group(2))
else:
    print('No valid phone number found')


superheroregex = re.compile(r'batman|superman|spiderman')
mo1=superheroregex.search('batman and superman are both superheroes')
if mo1:
    print('Found superhero: ' + mo1.group())



event = 108

for i in range(1, event + 1):
    if event %  i == 0:
        print(i,(event//i))