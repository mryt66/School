import pandas
import seaborn
import numpy
import random
from math import e, pi
from decimal import Decimal
from math import sqrt


class DataProcessing:
    data = None

    def __init__(self, d):
        self.data = d
        pandas.set_option('display.max_rows', len(self.data))

    def shuffle(self):
        for i in range(len(self.data) - 1, 0, -1):
            j = random.randint(0, i)
            self.data.iloc[i], self.data.iloc[j] = self.data.iloc[j], self.data.iloc[i]
        return self.data

    def normalize(self):
        listCopy = self.data.copy()
        values = listCopy.select_dtypes(exclude="object")
        columnNames = values.columns.tolist()
        for column in columnNames:
            data = listCopy.loc[:, column]
            minimum, maximum = min((data)), max(data)
            for row in range(0, len(listCopy), 1):
                value = (listCopy.at[row, column] - minimum) / (maximum - minimum)
                listCopy.at[row, column] = value
        self.data = listCopy

    def split(self):
        split = int(len(self.data) * 0.7)
        listTrain = self.data.iloc[:split, :]
        listVal = self.data.iloc[split:, :]
        return listTrain, listVal

rodzaje={"Virginica":1,"Versicolor":2,"Setosa":3}
class bayes:
    data=None
    def __init__(self, list1, list2):
        self.list1 = list1
        l1 = self.list1
        self.list2 = list2
        l2=self.list2


    def avg_dev(self):
        Average=[]
        Deviation=[]

        for j in range(0,4):
            tmpvir = 0
            ilvir = 0
            tmpver = 0
            ilver = 0
            tmpset = 0
            ilset = 0

            virlist = []
            verlist = []
            setlist = []
            for i in self.list1.iloc:
                if i[4]=="Virginica":
                    ilvir+=1
                    tmpvir+=float(i[j])
                    virlist.append(float(i[j]))

                elif i[4]=="Versicolor":
                    ilver+=1
                    tmpver +=float(i[j])
                    verlist.append(float(i[j]))
                elif i[4] == "Setosa":
                    ilset+=1
                    tmpset += float(i[j])
                    setlist.append(float(i[j]))

            tmpvir = round((tmpvir / ilvir),4)
            tmpver = round((tmpver / ilver),4)
            tmpset = round((tmpset / ilset),4)
            Average.append([tmpvir,tmpver,tmpset])

            #nie wiedziałem jak użyć tego wzorku,
            #więc zastosowałem gotową funkcje z biblioteki numpy

            Deviation.append([numpy.std(virlist),numpy.std(verlist),numpy.std(setlist)])

        return Average, Deviation

    def baju(self, avg, dev):
        listg = []
        x=self.list2.iloc[2]


        for i in range(4):
            tmp = []
            g=1
            for j in range(3):
                g = (e ** ((((-1 / 2) * (float(x[i]) - avg[i][j])) / dev[i][j]) ** 2)) / (dev[i][j] * sqrt(2 * pi))
                tmp.append(g)
            listg.append(tmp)
        print(listg)
        # [gvir1,gset1,gset1] [gvir2,gset2,gset2] [gvir3,gset3,gset3] [gvir4,gset4,gset4]

        vir_stat = 1
        ver_stat = 1
        set_stat = 1
        # mnożenie
        for i in range(4):
            vir_stat = vir_stat * listg[i][0]
            ver_stat = ver_stat * listg[i][1]
            set_stat = set_stat * listg[i][2]
        return vir_stat, ver_stat, set_stat

data = pandas.read_csv('iris.csv')
data.describe()
seaborn.pairplot(data, hue="variety")

x = DataProcessing(data)
x.shuffle()
x.normalize()
training, values = x.split()

print(training)
newx=bayes(training,values)

avg,dev=newx.avg_dev()
print(avg)
vir_stat,ver_stat,set_stat=newx.baju(avg,dev)










