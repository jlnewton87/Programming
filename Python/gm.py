import imaplib
def msgCount():
	obj = imaplib.IMAP4_SSL('imap.gmail.com','993')
	obj.login('jlnewton87@gmail.com','frccfcp3&7')
	obj.select()
	obj.search(None,'UnSeen')
	return len(obj.search(None, 'UnSeen')[1][0].split())
