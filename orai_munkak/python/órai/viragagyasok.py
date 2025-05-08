class agyasok:
    def __init__(self,sor):
        elso, utolso, szin = sor.split(' ')
        self.elso = int(elso)
        self.utolso = int(utolso)
        self.szín = szin

l = []
with open("felajanlas.txt","r",encoding="utf-8") as f:
    agyasszam = int(f.readline())
    for sor in f.read().splitlines():
        l.append(agyasok(sor))

print(f"2. feladat: \nA felajánlások száma: {len(l)}")

print(f"3. feladat: \n A bejárat mind két oldalán ültető: ",end=' ')
for i, e in enumerate(l):
    if e.elso > e.utolso:
        print(i + 1, end=' ')

print(f"4. feladat:")
sorsz = int(input("Adja meg az ágyás sorszámát: "))
db = 0
szinek = set()
for e in l:
    if e.elso <= sorsz <= e.utolso or e.elso > e.utolso and (e.elso <= sorsz or sorsz <= e.utolso):
        db += 1
        szinek.add(e.szín)
print(f"A felajánlások száma: {db}")

elsoszin = ''
for e in l:
    if e.elso <= sorsz <= e.utolso or e.elso > e.utolso and (e.elso <= sorsz or sorsz <= e.utolso):
        elsoszin = e.szín
        break
if elsoszin == '':
    print('Ezt az ágyást nem ültetik be')
else:
    print(f"A virágágyás színe, ha csak az első ültet: {elsoszin} ")

print(f"A virágágyás színei: ",end=' ')
for e in szinek:
    print(e, end=' ')    

print(f"\n 5. feladat:")
beultetve = set()
vallalt_db = 0
for e in l:
    if e.elso < e.utolso:
        vallalt_db += e.elso - e.utolso + 1
        for agyas in range(e.elso, e.utolso + 1):
            beultetve.add(agyas)
    else:
        vallalt_db += agyasszam - e.elso + 1 + e.utolso
        for agyas in range(e.elso, agyasszam + 1):
            beultetve.add(agyas)
        for agyas in range(1,e.utolso  + 1):
            beultetve.add(agyas)
if len(beultetve) == agyasszam:
    print('Minden ágyás beültetésére van jelentkező.')
elif vallalt_db >= agyasszam:
    print('Átszervezéssel megoldható a beültetés.')
else:
    print(f'A beültetés nem oldható meg.')

#tanár megoldás
print(f"5. feladat:")
ultet = [0]*agyasszam
for e in l:
    if e.elso <= e.utolso:
        for i in range(e.elso, e.utolso+1):
            ultet[i+1] += 1
    else:
        for i in range(e.elso, agyasszam):
            ultet[i-1] += 1
        for i in range(1,e.utolso + 1):
            ultet[i-1] += 1
van = False
for e in ultet:
    if e == 0:
        van = True
        break
if not van:
    print(f"Minden ágyás beültetésére van jelentkező.")
elif sum(ultet) >= agyasszam:
    print(f"Átszervezéssel megoldható a beültetés.")
else:
    print("A beültetés nem oldható meg")