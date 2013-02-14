import os
import easygui as eg

f = open('\\\\cmi01\\z\\Cmi_EmployeeFolders\\Josh\\TestTextFile.txt', 'w')
f.write('this is a test')
f.close()
eg.msgbox('Complete!')