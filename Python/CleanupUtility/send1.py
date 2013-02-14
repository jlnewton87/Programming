#!C:\Python27\python.exe
#Author: Joshua Newton
#Created: 3/29/2012
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

