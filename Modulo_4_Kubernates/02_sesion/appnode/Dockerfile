# Runtime o base que se ejecutara mi app
FROM node:21
# Establecemos directorio de trabajo dentro de la imagen
WORKDIR /usr/src/app
# Copiar el archivo de definicion
COPY package*.json ./
# instalar dependencias
RUN npm install
# copiar la solucion
COPY . .
# exponer el puerto
EXPOSE 3001
# comando que inicie la app
CMD [ "node", "app.js" ]
