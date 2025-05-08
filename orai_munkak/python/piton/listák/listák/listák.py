szamok = [] #Üres lista létrehozása
szam = int(input("Irjon be egy számot:"))

while szam != 0:
    szamok.append(szam) #hozzáfüzzük a listához a számot

    szam = int(input("Irjon be egy számot: "))

print(szamok)

paros = 0
paratlan = 0

for sz in szamok: #végig megyek a számok lista összes elemén
    if sz % 2 == 0: #Ha osztható 2-vel 
        paros += 1 #Növelem a párosok számát
    else:
        paratlan += 1 #Egyébként páratlan

print(f"{paros} db páros és {paratlan} db páratlan szám volt.")

import random 

lista = []

for i in range(50): #Ciklus 0-tól 49-ig
    vel = random.randint(1, 50) #1 és 50 közötti véletlenszám
    lista.append(vel)

print(lista)
print(lista[0]) #A lista első eleme
print(lista[-1]) #A lista utolsó eleme 
print(lista[:5]) #Az elsőtöl az 5-ik elemig (0-4)
print(lista[2:5]) #Lista a 3-iktól az 5-ik elemig (2-4)
print(lista[40:]) #Lista a 41-iktól az utolsó elemig (40-49)
print(lista.count(20)) #Hányszor szerepel a listában az elem 
print(lista.index(20)) #A megadott elem hányadik helyen van 
lista.insert(5,43) #A megadott index elé beszúrja az elemet
print(lista)
lista.sort() #Felfedezi a listát
print(lista)