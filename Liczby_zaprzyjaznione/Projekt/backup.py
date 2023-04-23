import os
from datetime import datetime
from os.path import exists
l1=[]
def otw(file):
    fil = open(file, "r")
    for i in fil:
       l1.append(i)
    print(l1)
    fil.close()
def whatever(file):
    if exists("raport.html"):
        os.remove("raport.html")
    now=datetime.now()
    fulldate = now.strftime("%d-%m-%Y %H:%M:%S")
    otw(file)
    fil2=open("raport.html","w")
    fil2.write("""
    <!DOCTYPE html>
    <html>
        <head>
            <style>
                table, th, td {
                border: 1px solid black;
                }
            </style>
        </head>
        <body>

            <h1>Raport z godziny: """+fulldate+"""</h1>

            <table>
                <tr>
                <th>Input</th>
                <th>Output</th>
            </tr>
            <tr>
                <td>"""+str(l1[0]) +"""</td>
                <td rowspan="2">"""+str(l1[2]) +"""</td>
            </tr>
            <tr>
                <td>"""+str(l1[1]) +"""</td>
            </tr>
            </table>
            <h4>Marcin Ryt</h4>
        </body>
    </html>

    """)
    fil2.close()

whatever("dane.txt")