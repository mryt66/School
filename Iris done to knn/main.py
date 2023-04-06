import pandas
import seaborn
import random
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


class co:
    def __init__(self, list1):
        self.list1 = list1
        l1 = self.list1
        self.list1 = l1.iloc[:, :-1] #self.list1 = l1.iloc[:, :-1]


    def euklides(self,k) -> list:
        euk2 = []
        for i in self.list1.iloc: #for i in self.list1.iloc:
            euk = []
            for j in self.list1.iloc:
                euk.append([j.name,sqrt((Decimal(i[0]) - Decimal(j[0])) ** 2 + (Decimal(i[1]) - Decimal(j[1])) ** 2 + (
                    Decimal(i[2]) - Decimal(j[2])) ** 2 + (Decimal(i[3]) - Decimal(j[3])) ** 2)])
            sorting(euk)
            if k==2:
                euk2.append([i.name+1, euk[0][0], euk[1][0]])  # 5 nearest neighbours
            elif k==3:
                euk2.append([i.name+1, euk[0][0], euk[1][0], euk[2][0]])  # 5 nearest neighbours
            elif k==4:
                euk2.append([i.name+1, euk[0][0], euk[1][0], euk[2][0], euk[3][0]])

        return euk2

#Reversed sorting with index
def sorting(euk) -> list:
    for i in range(1,len(euk)):
        for j in range(1,len(euk)):
            if euk[j-1][1]<euk[j][1]:
                tmp=euk[j-1]
                euk[j-1]=euk[j]
                euk[j]=tmp
    return euk

data = pandas.read_csv('iris.csv')
data.describe()
seaborn.pairplot(data, hue="variety")

x = DataProcessing(data)
x.shuffle()
x.normalize()
training, values = x.split()

k=2 #how many neighbours (2-4)
#for k=2 list looks like [[idoftarget,id_of_neighbour1,id_of_neighbour2]]

newx=co(training)
print(newx.euklides(k))
