#Creates new Python source file
import datetime
now = datetime.datetime.now()
today = str(now.month) + '/' + str(now.day) + '/' + str(now.year)
f = open('./RENAMEME.py', 'w')
f.write('#!C:\Python27\python.exe\n#Author: Joshua Newton\n#Created: ' + today + '\n')
f.close()