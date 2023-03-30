#Program do wyboru najlepszych


def fun(list):
    for j in range(1,len(list)):
        tmp2 = list[0][1]
        for i in range(1, len(list)):
            if list[i][1]>tmp2:
                tmp2=list[i - 1][1]
                list[i - 1][1] = list[i][1]
                list[i][1]=tmp2
    return list


# Zmienianie kryteriow
A = {"swieze": 1, "zimne": 0.5,"uschniety":0.2}
B = {"swieze": 1, "zimne": 0.5,"uschniety":0.2}
C = {"swieze": 1, "zielone": 0.5,"gorace":1}

# ile ma wypisac
top = 3

file = open("baza", "r")
l1 = []
for i in file:
    i = i.strip('\n')
    l1.append(i.split(","))

tmpa = 0
tmpb = 0
tmpc = 0
magz = 0
l2 = []
for i in l1:
    tmpa = 0
    tmpb = 0
    tmpc = 0

    for j in i:
        if j in A:
            tmpa += A[str(j)]
        if j in B:
            tmpb += B[str(j)]
        if j in C:
            tmpc += C[str(j)]
    magz=max([tmpa,tmpb,tmpc])
    if magz>0:
        l2.append([i[0], magz])
l2=fun(l2)
if len(l2) >= top:
    for i in range(top):
        print(l2[i])
else:
    print(l2) 