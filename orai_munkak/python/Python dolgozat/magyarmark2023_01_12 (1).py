# -*- coding: utf-8 -*-
"""MagyarMark2023.01.12.ipynb

Automatically generated by Colaboratory.

Original file is located at
    https://colab.research.google.com/drive/1tbmNQx_gBGHtJqlwG3Z2GCs_FRvvReeJ
"""

def fgv(r):
  kor = 2*r*3.14
  return(kor)

import random
k = int(input("szám: "))
fgv(k)
db = 0

lista = [random.randint(1,100) for _ in range(100)]
for i in lista:
  if fgv(i) > fgv(k):
    db += 1
print(f"{db} kerületü kör van")