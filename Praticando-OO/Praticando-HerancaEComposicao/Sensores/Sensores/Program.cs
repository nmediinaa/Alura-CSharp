using Sensores.Interfaces;
using Sensores.Models;

SensorDePresenca s1 = new SensorDePresenca();

SensorDeTemperatura s2 = new SensorDeTemperatura();

s1.Ativar();
s2.Ativar();

s1.Desativar();
s2.Desativar();