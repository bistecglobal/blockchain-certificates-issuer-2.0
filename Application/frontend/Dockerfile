# ---- Base Node ----
FROM node:18-alpine AS base
WORKDIR /frontend
COPY package.json ./

# ---- Dependencies ----
FROM base AS dependencies
RUN npm install

# ---- Copy Files/Build ----
FROM dependencies AS build
COPY . .
RUN npm run build

# ---- Release ----
FROM base AS release
COPY --from=build /frontend/.next ./.next
COPY --from=build /frontend/node_modules ./node_modules
COPY --from=build /frontend/package.json ./package.json

EXPOSE 8080
ENTRYPOINT [ "npm", "run", "start", "--", "-p", "8080" ]