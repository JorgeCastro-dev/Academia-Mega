# Usa una imagen base de Node.js
FROM node:latest

# Establece el directorio de trabajo
WORKDIR /usr/src/app

# Copia el archivo de dependencias
COPY package*.json ./

# Instala las dependencias
RUN npm install

# Copia el código
COPY . .

# Expone el puerto que usará la app
EXPOSE 3001

# Comando para ejecutar la app
CMD ["node", "app.js"]
