#1-100-ig írjuk ki a számokat
szam = 1
while szam <= 100:
    print(szam)
    szam = szam + 1 #szam += 1

#írja ki az első 30 négyzet számot

for i in range(1, 31, 1):
    print(i ** 2)

#200-tól visszafelé az összes páros számot írjuk ki!
for i in range(200, 1, -2):
    print(i)

#Kamatos kamat:
osszeg = int(input("Ősszeg: "))
kamat = float(input("Kamatláb: "))
ev = int(input("Futamidő: "))

for i in range(ev): #range(0, ev, 1)
    osszeg *= (1 + kamat / 100)
print(osszeg, "Ft")
