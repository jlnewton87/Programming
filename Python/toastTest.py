#!C:\Python27\python.exe
#Author: Joshua Newton
#Created: 3/16/2012
import wx
import wx.lib.agw.toasterbox as TB

class MyFrame(wx.Frame):

    def __init__(self, parent):

        wx.Frame.__init__(self, parent, -1, "ToasterBox Demo")

        toaster = TB.ToasterBox(self, tbstyle=TB.TB_COMPLEX)
        toaster.SetPopupPauseTime(3000)

        tbpanel = toaster.GetToasterBoxWindow()
        panel = wx.Panel(tbpanel, -1)
        sizer = wx.BoxSizer(wx.VERTICAL)

        button = wx.Button(panel, wx.ID_ANY, "Simple button")
        sizer.Add(button, 0, wx.EXPAND)

        panel.SetSizer(sizer)
        toaster.AddPanel(panel)

        wx.CallLater(1000, toaster.Play)


# our normal wxApp-derived class, as usual

app = wx.PySimpleApp()

frame = MyFrame(None)
app.SetTopWindow(frame)
frame.Show()

app.MainLoop()