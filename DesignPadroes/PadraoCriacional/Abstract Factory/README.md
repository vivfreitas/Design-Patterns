# 🏗️ Abstract Factory

Abstract Factory é um padrão que cria conjuntos de objetos relacionados garantindo que eles sejam compatíveis entre si, sem que o código precise instanciar diretamente as classes concretas.
___
Um bom exemplo é quando estamos fazendo um sistema de banco. Dentro dele temos:
**PIX** e **CARTÃO**.

#### PIX precisa de:
- Gerador de QR Code
- Validador de chave PIX

#### Cartão precisa de:
- Processador de cartão
- Validador de CVV

_Concorda comigo que se usarmos o Validador de CVV no PIX não faria sentido?_

De início você se assustará com o tanto de interfaces e classes, mas a estrutura sempre seguirá esse padrão:

**Estrutura real:**
- IProcessador → tipo genérico 
- IPlacaMae → tipo genérico 
- IHardwareFactory → contrato da fábrica

**E depois:**
- AMDProcessador → implementação 
- AMDPlacaMae → implementação 
- AMDFactory → junta tudo

### 🚫 NÃO use Abstract Factory quando....
1. Só tiver um objeto.
2. Os objetos NÃO dependem uns dos outros
3. Se o seu OBJETO será sempre a mesma família, mas com variações diferentes.

Quando for usar, sempre se pergunte: _´O sistema terá famílias?´_
___
### Exemplos de código
Para entender melhor, você pode navegar nas pastas de _"código ruim."_ e _"código bom"_.