from distutils.core import setup
import py2exe
#Add name of .py file to exe-Ify!
exe = './testpy2exe2.py'
setup(console=[exe])

#now run --__--  python exeIfy.py py2exe --__--