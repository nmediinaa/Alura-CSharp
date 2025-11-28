using CertificadoProfissoes.Models;

Analista an1 = new ("Analista");
Assistente as1 = new ("Assistente");

Certificado cf1 = new(an1);
Certificado cf2 = new(as1);

cf1.Emitir();
cf2.Emitir();
