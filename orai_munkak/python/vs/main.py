import random

N = 20
random.seed(100)
A = [random.randint(1,100) for _ in range(0,N)]
print(*A)

#összegzés algoritmusa

i = 0
szum = 0
while i < N:
    szum += A[i]
    i += 1
print(f"A sorozat elemeinek összege {szum}")

szum = 0
for i in range(0, N):
    szum += A[i]
print(f"A sorozat elemeinek összege {szum}")

szum = 0
for e in A:
    szum += e
print(f"A sorozat elemeinek összege {szum}")

#Szorzás algoritmusa
szum = 1
for e in A:
    szum *= e
print(f"A sorozat elemeinek szorzata {szum}")

#Összefűzés
B = ["a","l","m","a","f","a"]
szum = ''
for e in B:
    szum += e
print(f"A sorozat elemeinek szorzata {szum}")

#Eldöntés algoritmusa
i = 0
van = False
while i < N and not van:
    if A[i] % 3 == 0:
        van = True
    i += 1
print(f"{'van' if van else 'nincs'} a sotozatban 3-mal osztható elem")

van = False
for e in A:
    if e % 3 == A:
        van = True
        break
print(f"{'van' if van else 'nincs'} a sotozatban 3-mal osztható elem")

i = 0
while i < N:
    if A[i] % 3 == 0:
        break
    i += 1
print(f"{'van' if i < N else 'nincs'} a sotozatban 3-mal osztható elem")

#kiválasztás tétele
i = 0
while A[i] % 2 != 0:
    i += 1
print(f"Az első páros szám: {A[i]}, A szám indexe: {i}")

for i in range(len(A)):
    if A[i] % 2 == 0:
        break
print(f"Az első páros szám: {A[i]}, A szám indexe: {i}")

#Lineáris keresés tétele

i = 0
VAN = False
while i < N and not VAN:
    if A[i] % 3 == 0:
        VAN = True
    i += 1
i -= 1
if VAN:
    print(f"Az első hárommal osztható szám: {(A[i])}, A szám indexe: {i}")
else:
    print(f"Nincs hárommal osztható szám a sorozatban")

VAN = False
for i in range(N):
    if A[i] % 3 == 0:
        VAN = True
        break
if VAN:
    print(f"Az első hárommal osztható szám: {(A[i])}, A szám indexe: {i}")
else:
    print(f"Nincs hárommal osztható szám a sorozatban")

#írj olyan programot amely megkeresi az utolsó 3-al osztható elemet

van = False
for i in reversed(range(N)):
    if A[i] % 3 == 0:
        van = True
        break
if VAN:
    print(f"Az első hárommal osztható szám: {(A[i])}, A szám indexe: {i}")
else:
    print(f"Nincs hárommal osztható szám a sorozatban")

#tanár megoldás
van = False
for i in range(N-1, 0, -1):
    if A[i] % 3 == 0:
        van = True
        break
if VAN:
    print(f"Az első hárommal osztható szám: {(A[i])}, A szám indexe: {i}")
else:
    print(f"Nincs hárommal osztható szám a sorozatban")

#írj egy olyan programot amely el dönti, hogy van-e olyan szám amelynek mindkét szomszédja páros
