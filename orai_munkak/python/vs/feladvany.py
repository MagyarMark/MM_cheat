import math
import random

class Feladvany:
    def __init__(self, sor):
        self.kezdo = sor
        self.meret = int(math.sqrt(len(sor)))

    def kirajzol(self):
        for i in range(len(self.kezdo)):
            if self.kezdo[i] == '0':
                print('.', end = '')
            else:
                print(self.kezdo[i], end = '')
            if i % self.meret == self.meret - 1:
                print()

l = []
with open('feladvanyok.txt', 'r', encoding='utf-8') as f:
    for sor in f.readlines():
        l.append(Feladvany(sor.strip()))
        
print(f'3. feladat: Beolvasva {len(l)} feladvány')

meret = 0
while True:
    meret = int(input('4. feladat: Kérem a feladvány méretét [4..9]: '))
    if 4 <= meret <= 9:
        break
db = 0
for e in l:
    if e.meret == meret:
        db += 1
print(f"{meret}x{meret}méretű feladványból {db} darab van tárolva")

v = 0
while True:
    v = random.randint(0, len(l))
    if l[v].meret == meret:
        break
print(f"5. feladat, A kiválasztott feladvány: ")
print(l[v].kezdo)

k = 0
for b in l[v].kezdo:
    if b != 0:
        k += 1
print(f"6. feladat, A feladvány kitöltöttsége:{k / meret * meret * 100:.0f}")

print(f"7. feladat a feladvány kirajzolva")
l[v].kirajzol()