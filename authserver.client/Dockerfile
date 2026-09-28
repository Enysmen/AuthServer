FROM node:24-bookworm-slim AS build
WORKDIR /app 

COPY ["authserver.client/package.json","authserver.client/package-lock.json","./"]
RUN npm ci


COPY authserver.client/ ./
RUN npm run build

FROM nginx:1.30-alpine AS final

COPY authserver.client/nginx.conf /etc/nginx/conf.d/default.conf
COPY --from=build /app/dist/ /usr/share/nginx/html/


EXPOSE 80