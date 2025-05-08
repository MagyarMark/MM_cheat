class Epulet:
    def __init__(self, sor):
        nev, varos, orszag, magassag, emelet, epult = sor.split(";")
        self.nev = nev
        self.varos = varos
        self.orszag = orszag
        self.magassag = float(magassag.replace(',', '.'))
        self.emelet = int(emelet)
        self.epult = int(epult)

epuletek = []

with open("legmagasabb.txt", "r", encoding="utf-8") as f:
    for sor in f.read().splitlines()[1:]:
        epuletek.append(Epulet(sor))

print(f"3.2 feladat: Epületek száma: {len(epuletek)}Db")

ossz_emelet = 0
for e in epuletek:
    ossz_emelet += e.emelet
print(f"3.3 feladat: emeletek összege: {ossz_emelet}")

max_epulet = epuletek[0]
for e in epuletek:
    if e.magassag > max_epulet.magassag:
        max_epulet = e
print(f"3.4 feladat: A legmagasabb épület adatai: ")
print(f"\tNév: {max_epulet.nev}")
print(f"\tváros: {max_epulet.varos}")
print(f"\torszag: {max_epulet.orszag}")
print(f"\tmagassag: {max_epulet.magassag}")
print(f"\temeletk száma: {max_epulet.emelet}")
print(f"\tépületek: {max_epulet.epult}")

van = False
for e in epuletek:
    if e.orszag == 'Olaszország':
        van = True
        break
print(f'3.5 feladat: {"van" if van else "nincs"}')



