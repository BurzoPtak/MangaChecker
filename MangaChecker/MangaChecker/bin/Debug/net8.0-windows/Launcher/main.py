import json
from urllib.request import Request,urlopen
import webbrowser
import re
import os
try:
    path = os.path.join(os.path.dirname(__file__), "Mangas/Saves.json")
    print(path)
    f = open(path)
except:
    input("Data not found! Import data to /Mangas/Saves.json")
    quit()
data = json.load(f)
for i in data:
    isOpen = False
    while(True):
        flag = False
    #requesting url and scrambling request so filter wont catch
        req = Request(url=i['url'],headers={'User-Agent': 'Mozilla/5.0'})
        webpage = urlopen(req).read()
    #Looking for int or float chapter pattern assuming last number is chapter number
        chapter = re.findall(r"\d+\.\d+",i['url'])
        if len(chapter) == 0:
            chapter = re.findall(r'\d+', i['url'])
        chapter = chapter[len(chapter)-1]
    #slicing url so we can add increased chapter number
        link = i['url'][:len(i['url'])-len(chapter)]
    # Scanning if new chapter is available
        for j in range(0,12): #if you want to lessen accuracy I recommend 0,4 cause chapter 1.1, 1.2, 2 and 4th for checking higher
            chapterFL = str(int((float(chapter))))
            chapterFL = chapterFL+"."+str(j)
            if j < 10:
                snippet = i['snippet'].split("|")[0]+link+ chapterFL + i['snippet'].split("|")[1]
            elif j >= 10:
                chapterFL = str(int(float(chapterFL) +1))
                snippet = i['snippet'].split("|")[0]+link+ chapterFL + i['snippet'].split("|")[1]
            if j == 11:
                chapterFL = chapterFL+"."+str(1)
                snippet = i['snippet'].split("|")[0] + link + chapterFL + i['snippet'].split("|")[1]
            if snippet in str(webpage):
                if not isOpen:
                    webbrowser.open(i['url'],new=0,autoraise=True)
                    isOpen = True
                i['url'] = link + chapterFL
                flag = True
        if flag:
            continue
        else:
            break

#Saving file
try:
    jsonSave = json.dumps(data,indent=4)
    with open(path,"w") as fileSave:
        fileSave.write(jsonSave)
except:
    input("Something went wrong :/")
    quit()






