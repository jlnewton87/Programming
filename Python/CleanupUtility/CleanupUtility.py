#!C:\Python27\python.exe
#Author: Joshua Newton
#Created: 3/30/2012
import os, sqlite3, datetime
import smtplib
from email.MIMEText import MIMEText


class send:
	def __init__(self, Subject, Reciept, Message):
		
		passwd = 'frccfcp3&7'
		uname = 'jlnewton87'
		email = uname + '@gmail.com'
		self.To = Reciept
		self.Subject = Subject
		self.Message = Message

		gmail = smtplib.SMTP('smtp.gmail.com', 587)
		gmail.ehlo()
		gmail.starttls()
		gmail.ehlo()
		gmail.login(uname, passwd)
		gmail.mail(email)
		gmail.rcpt(self.To)
		gmail.data("Subject: " + self.Subject + '\n\n' + self.Message)
		gmail.quit()

class index:
	list = []
	delete = []
	old = {}
	def __init__(self):
		os.chdir(r'Y:\\')
		list = os.listdir('./')
		for dir in list:
			if dir[0] != '2':
				list.remove(dir)
			else:
				self.list.append(dir)
				
	def onlyNewDirs(self):
		conn = sqlite3.connect('Y:\\projects.sq3')
		c = conn.cursor()
		c.execute("""SELECT name, dtCreate FROM projectList""")
		self.list2 = []
		for row in c:
			for dirinlist in self.list:
				if row[0] == dirinlist:
					self.old[dirinlist] = row[1]
					self.list.remove(dirinlist)
				else:
					pass
					
	def record(self):
		conn = sqlite3.connect('Y:\\projects.sq3')
		c = conn.cursor()
		for dir in self.list:
			c.execute('INSERT INTO projectList (name) values ("' + str(dir) + '")')
		conn.commit()
		c.close
		
	def checkDates(self):
		for project_date in self.old:
			date_time = self.old[project_date]
			date_time_separate = date_time.split(' ')
			date_separate = date_time_separate[0].split('-')
			date_object = datetime.date(int(date_separate[0]), int(date_separate[1]), int(date_separate[2]))
			if datetime.date.today() >= date_object + datetime.timedelta(+30):
				self.delete.append(project_date)
			
	def notify(self):
		message = 'List of projects to delete: \n\n'
		for project in self.delete:
			message += project + '\n'
		send('Projects to remove from Y', 'jhernandez@cmiresearch.com', message)
	
	def clearDatabase(self):
		conn = sqlite3.connect('Y:\\projects.sq3')
		c = conn.cursor()
		c.execute("""SELECT name, dtCreate FROM projectList""")
		self.list2 = []
		for row in c:
			if row[0] in os.listdir('./'):
				pass
			else:
				c.execute('DELETE FROM projectList WHERE name="' + row[0] + '"')
				conn.commit()
				c.quit()
	def log(self):
		f = open('./lastrun.log', 'w')
		f.write('------Y Drive Cleanup Utility------\nLast Run: ' + str(datetime.date.today()))
		f.close()
if __name__ == '__main__':	
	y = index()
	y.onlyNewDirs()
	y.record()
	y.checkDates()
	if len(y.delete) > 0:
		y.notify()
	y.log()
	y.clearDatabase()