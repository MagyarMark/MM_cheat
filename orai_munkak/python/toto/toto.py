
class Toto:
    def __init__(self, sor):
        ev, het, fordulo, t13p1, ny13p1, eredmenyek = sor.split(";")
        self.ev = int(ev)
        self.het = int(het)
        self.fordulo = int(fordulo)
        self.t13p1 = int(t13p1)
        self.ny13p1 = int(ny13p1)
        self.eredmenyek = (eredmenyek)

adatok = []
with open("toto.txt","r",encoding="utf-8") as f:
    for sor in f.read().splitlines()[1:]:
        adatok.append(Toto(sor))

print(f"2. feladat: Fogadási fordulatok száma: {len(adatok)} ")

db1 = 0

for e in adatok:
    db1 += e.t13p1
print(f"3. feladat: {db1}")

volt = False
for e in adatok:
    if e.nem_volt_dontetlen():
        volt = True
        break
print(f'4. feladat: {"Volt" if volt else "Nem volt"} döntetlen mentes forduló')
