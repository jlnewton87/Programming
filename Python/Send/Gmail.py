#!C:\Python27\python.exe
#Author: Joshua Newton
#Created: 3/29/2012
import smtplib, getpass
from email.MIMEText import MIMEText

uname = 'jlnewton87'
passwd = getpass.getpass()
email = uname + '@gmail.com'
To = raw_input('To: \n')

gmail = smtplib.SMTP('smtp.gmail.com', 587)
gmail.ehlo()
gmail.starttls()
gmail.ehlo()
gmail.login(uname, passwd)
gmail.mail(email)
gmail.rcpt(To)
gmail.data("Subject: " + raw_input('Subject: \n') + '\n\n' + raw_input('Message: \n'))
gmail.quit()
