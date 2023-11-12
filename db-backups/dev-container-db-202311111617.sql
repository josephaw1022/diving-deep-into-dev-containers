--
-- PostgreSQL database dump
--

-- Dumped from database version 15.4
-- Dumped by pg_dump version 15.3 (Debian 15.3-0+deb12u1)

SET statement_timeout = 0;
SET lock_timeout = 0;
SET idle_in_transaction_session_timeout = 0;
SET client_encoding = 'UTF8';
SET standard_conforming_strings = on;
SELECT pg_catalog.set_config('search_path', '', false);
SET check_function_bodies = false;
SET xmloption = content;
SET client_min_messages = warning;
SET row_security = off;

SET default_tablespace = '';

SET default_table_access_method = heap;

--
-- Name: AuthSession; Type: TABLE; Schema: public; Owner: josephaw1022
--

CREATE TABLE public."AuthSession" (
    id uuid NOT NULL,
    "userId" integer NOT NULL
);


ALTER TABLE public."AuthSession" OWNER TO josephaw1022;

--
-- Name: AuthUser; Type: TABLE; Schema: public; Owner: josephaw1022
--

CREATE TABLE public."AuthUser" (
    "Id" integer NOT NULL,
    "firstName" text NOT NULL,
    "lastName" text NOT NULL,
    "dateOfBirth" timestamp with time zone DEFAULT '-infinity'::timestamp with time zone NOT NULL,
    email text DEFAULT ''::text NOT NULL
);


ALTER TABLE public."AuthUser" OWNER TO josephaw1022;

--
-- Name: AuthUser_Id_seq; Type: SEQUENCE; Schema: public; Owner: josephaw1022
--

ALTER TABLE public."AuthUser" ALTER COLUMN "Id" ADD GENERATED BY DEFAULT AS IDENTITY (
    SEQUENCE NAME public."AuthUser_Id_seq"
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1
);


--
-- Name: __EFMigrationsHistory; Type: TABLE; Schema: public; Owner: josephaw1022
--

CREATE TABLE public."__EFMigrationsHistory" (
    "MigrationId" character varying(150) NOT NULL,
    "ProductVersion" character varying(32) NOT NULL
);


ALTER TABLE public."__EFMigrationsHistory" OWNER TO josephaw1022;

--
-- Data for Name: AuthSession; Type: TABLE DATA; Schema: public; Owner: josephaw1022
--

COPY public."AuthSession" (id, "userId") FROM stdin;
\.


--
-- Data for Name: AuthUser; Type: TABLE DATA; Schema: public; Owner: josephaw1022
--

COPY public."AuthUser" ("Id", "firstName", "lastName", "dateOfBirth", email) FROM stdin;
\.


--
-- Data for Name: __EFMigrationsHistory; Type: TABLE DATA; Schema: public; Owner: josephaw1022
--

COPY public."__EFMigrationsHistory" ("MigrationId", "ProductVersion") FROM stdin;
20231104181119_InitialCreate	7.0.13
20231104181655_add-new-authuser-property	7.0.13
20231104182523_add-new-authuser-property2	7.0.13
20231104212519_newemailfield	7.0.13
20231104213418_add-password	7.0.13
20231104213602_remove-password	7.0.13
\.


--
-- Name: AuthUser_Id_seq; Type: SEQUENCE SET; Schema: public; Owner: josephaw1022
--

SELECT pg_catalog.setval('public."AuthUser_Id_seq"', 1, false);


--
-- Name: AuthSession PK_AuthSession; Type: CONSTRAINT; Schema: public; Owner: josephaw1022
--

ALTER TABLE ONLY public."AuthSession"
    ADD CONSTRAINT "PK_AuthSession" PRIMARY KEY (id);


--
-- Name: AuthUser PK_AuthUser; Type: CONSTRAINT; Schema: public; Owner: josephaw1022
--

ALTER TABLE ONLY public."AuthUser"
    ADD CONSTRAINT "PK_AuthUser" PRIMARY KEY ("Id");


--
-- Name: __EFMigrationsHistory PK___EFMigrationsHistory; Type: CONSTRAINT; Schema: public; Owner: josephaw1022
--

ALTER TABLE ONLY public."__EFMigrationsHistory"
    ADD CONSTRAINT "PK___EFMigrationsHistory" PRIMARY KEY ("MigrationId");


--
-- Name: IX_AuthSession_userId; Type: INDEX; Schema: public; Owner: josephaw1022
--

CREATE INDEX "IX_AuthSession_userId" ON public."AuthSession" USING btree ("userId");


--
-- Name: AuthSession FK_AuthSession_AuthUser_userId; Type: FK CONSTRAINT; Schema: public; Owner: josephaw1022
--

ALTER TABLE ONLY public."AuthSession"
    ADD CONSTRAINT "FK_AuthSession_AuthUser_userId" FOREIGN KEY ("userId") REFERENCES public."AuthUser"("Id") ON DELETE CASCADE;


--
-- PostgreSQL database dump complete
--

