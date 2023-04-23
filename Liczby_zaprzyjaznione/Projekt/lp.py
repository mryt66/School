def sum_dziel(n):
    suma = 0
    for i in range(1, (n // 2 + 2)):
        if n % i == 0:
            suma += i
    return suma
l1=[]
def podaj_liczbe(sciezka):
    f=open(sciezka,"r")
    for i in f:
        try:
            if int(i)>0:
                l1.append(int(i))
            else:
                raise ValueError
        except:
            print("Podałeś złe dane")
            break
    f.close()
podaj_liczbe("input.txt")
print(l1)

filename="dane.txt"
f2=open(filename, "w")
for j in range(1,(len(l1)//2)+2,2):
    if l1[j-1]==sum_dziel(l1[j]) and l1[j]== sum_dziel(l1[j-1]) and l1[j-1]!=l1[j]:
        output="Liczby ", l1[j-1], " i ", l1[j], " sa zaprzyjaznione"
    else:
        output="Liczby ", l1[j-1], " i ", l1[j], " nie sa zaprzyjaznione"
    f2.write(str(l1[j-1]))
    f2.write('\n')
    f2.write(str(l1[j]))
    f2.write('\n')
    f2.write(str(output))
    f2.write('\n')
    print(output)
f2.close()


