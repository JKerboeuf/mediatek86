-- phpMyAdmin SQL Dump
-- version 5.2.0
-- https://www.phpmyadmin.net/
--
-- Hôte : 127.0.0.1:3306
-- Généré le : lun. 29 mai 2023 à 16:22
-- Version du serveur : 8.0.31
-- Version de PHP : 8.0.26

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de données : mediatek86
--

-- --------------------------------------------------------

--
-- Structure de la table absence
--

DROP TABLE IF EXISTS absence;
CREATE TABLE absence (
  idpersonnel int NOT NULL,
  datedebut datetime NOT NULL,
  idmotif int NOT NULL,
  datefin datetime DEFAULT NULL
) ENGINE=MyISAM DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Déchargement des données de la table absence
--

INSERT INTO absence (idpersonnel, datedebut, idmotif, datefin) VALUES
(3, '2023-02-17 08:43:00', 2, '2023-09-09 05:03:00'),
(1, '2023-06-16 11:36:00', 3, '2023-08-28 07:57:00'),
(6, '2023-04-05 13:36:00', 2, '2023-09-27 09:38:00'),
(1, '2023-04-07 20:33:00', 4, '2023-07-06 08:29:00'),
(3, '2023-02-21 00:34:00', 4, '2023-08-30 20:56:00'),
(5, '2023-03-25 14:16:00', 2, '2023-12-06 10:59:00'),
(3, '2023-05-05 18:08:00', 4, '2023-09-20 12:12:00'),
(9, '2023-02-19 09:54:00', 3, '2023-07-30 02:22:00'),
(8, '2023-05-22 02:10:00', 4, '2023-11-14 04:10:00'),
(6, '2023-01-15 18:06:00', 4, '2023-11-02 00:11:00'),
(8, '2023-04-05 23:04:00', 2, '2023-10-22 17:40:00'),
(3, '2023-05-27 22:42:00', 3, '2023-09-05 07:02:00'),
(1, '2023-06-23 05:02:00', 1, '2023-12-13 16:24:00'),
(6, '2023-01-20 23:59:00', 2, '2023-12-27 10:18:00'),
(9, '2023-06-17 21:28:00', 2, '2023-08-06 14:48:00'),
(1, '2023-05-12 05:51:00', 2, '2023-07-15 02:13:00'),
(8, '2023-04-15 23:22:00', 3, '2023-08-19 21:42:00'),
(1, '2023-04-06 18:29:00', 4, '2023-12-09 20:09:00'),
(9, '2023-05-03 16:30:00', 4, '2023-07-03 20:12:00'),
(14, '2023-05-16 17:44:05', 2, '2023-05-18 17:44:05'),
(9, '2023-04-07 11:53:00', 4, '2023-07-26 10:30:00'),
(9, '2023-05-21 13:35:00', 1, '2023-11-06 00:27:00'),
(8, '2023-03-15 16:32:00', 4, '2023-11-11 08:27:00'),
(1, '2023-02-21 14:02:00', 1, '2023-12-29 01:38:00'),
(8, '2023-06-18 09:28:00', 1, '2023-08-05 03:20:00'),
(9, '2023-04-19 14:31:00', 3, '2023-11-20 04:17:00'),
(10, '2023-05-10 14:52:14', 2, '2023-05-20 14:52:14'),
(1, '2023-03-01 18:51:00', 1, '2023-10-15 05:11:00'),
(5, '2023-02-15 16:46:00', 1, '2023-08-11 02:23:00'),
(5, '2023-02-16 01:03:00', 2, '2023-09-15 14:23:00'),
(5, '2023-02-19 12:33:00', 4, '2023-07-28 12:10:00'),
(3, '2023-06-19 21:28:00', 3, '2023-09-23 03:55:00'),
(4, '2023-04-26 14:44:00', 3, '2023-11-07 17:11:00'),
(4, '2023-05-12 01:17:00', 1, '2023-08-03 02:00:00'),
(5, '2023-01-01 09:44:00', 2, '2023-09-19 02:15:00'),
(8, '2023-04-01 17:20:00', 4, '2023-09-25 21:47:00'),
(1, '2023-03-13 00:51:00', 1, '2023-12-16 22:36:00'),
(13, '2022-12-29 14:53:57', 2, '2023-05-29 14:53:57'),
(8, '2023-01-22 00:03:00', 2, '2023-08-15 15:52:00'),
(1, '2023-05-29 14:53:24', 3, '2023-06-03 14:53:23'),
(1, '2023-01-26 12:28:00', 1, '2023-10-13 21:34:00'),
(1, '2023-02-11 12:11:00', 3, '2023-10-07 16:20:00'),
(3, '2023-02-01 01:52:00', 2, '2023-12-13 13:29:00'),
(10, '2023-02-20 12:22:00', 2, '2023-07-13 03:35:00');

-- --------------------------------------------------------

--
-- Structure de la table motif
--

DROP TABLE IF EXISTS motif;
CREATE TABLE motif (
  idmotif int NOT NULL,
  libelle varchar(128) COLLATE utf8mb4_unicode_ci DEFAULT NULL
) ENGINE=MyISAM DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Déchargement des données de la table motif
--

INSERT INTO motif (idmotif, libelle) VALUES
(1, 'vacances'),
(2, 'maladie'),
(3, 'motif familial'),
(4, 'congé parental');

-- --------------------------------------------------------

--
-- Structure de la table personnel
--

DROP TABLE IF EXISTS personnel;
CREATE TABLE personnel (
  idpersonnel int NOT NULL,
  idservice int NOT NULL,
  nom varchar(50) COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  prenom varchar(50) COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  tel varchar(15) COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  mail varchar(128) COLLATE utf8mb4_unicode_ci DEFAULT NULL
) ENGINE=MyISAM DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Déchargement des données de la table personnel
--

INSERT INTO personnel (idpersonnel, idservice, nom, prenom, tel, mail) VALUES
(4, 1, 'Cunningham', 'Bianca', '03 95 56 33 86', 'lacus.quisque@yahoo.edu'),
(3, 3, 'Snow', 'Kevin', '03 35 85 78 80', 'a@protonmail.net'),
(13, 2, 'Rabat', 'Bernard', '0646133052', 'Rabat.Bernard@gmail.com'),
(14, 1, 'Bougoul', 'Jean-Patrick', '06 46 13 30 52', 'lpr@gmail.com'),
(1, 2, 'Padilla', 'Blaze', '08 42 47 16 37', 'eget.laoreet@google.couk'),
(5, 2, 'Winters', 'Chelsea', '05 32 25 72 68', 'vel.lectus@yahoo.edu'),
(6, 1, 'Maddox', 'Katell', '03 92 74 63 58', 'porttitor.tellus.non@google.ca'),
(15, 1, 'Bertrand', 'Jean', '06 06 06 06 06', 'oui.toutpareil@gmail.com'),
(8, 2, 'Blair', 'Lacota', '02 14 36 15 74', 'vitae.erat@icloud.net'),
(9, 2, 'Greer', 'Zachery', '09 98 66 98 24', 'sapien.imperdiet@google.net'),
(10, 2, 'Pratt', 'Tatyana', '07 65 42 44 31', 'mi.tempor@aol.com');

-- --------------------------------------------------------

--
-- Structure de la table responsable
--

DROP TABLE IF EXISTS responsable;
CREATE TABLE responsable (
  login varchar(64) COLLATE utf8mb4_unicode_ci NOT NULL,
  pwd varchar(64) COLLATE utf8mb4_unicode_ci NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Déchargement des données de la table responsable
--

INSERT INTO responsable (login, pwd) VALUES
('MediaTek86admin', '0c1c86a99073e991c5cebdfad981bd196c433ef8d1f396a0975ca603ce5eedd8');

-- --------------------------------------------------------

--
-- Structure de la table service
--

DROP TABLE IF EXISTS service;
CREATE TABLE service (
  idservice int NOT NULL,
  nom varchar(50) COLLATE utf8mb4_unicode_ci DEFAULT NULL
) ENGINE=MyISAM DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Déchargement des données de la table service
--

INSERT INTO service (idservice, nom) VALUES
(1, 'administratif'),
(2, 'médiation culturelle'),
(3, 'prêt');

--
-- Index pour les tables déchargées
--

--
-- Index pour la table absence
--
ALTER TABLE absence
  ADD PRIMARY KEY (idpersonnel,datedebut),
  ADD KEY i_fk_absence_motif1 (idmotif),
  ADD KEY i_fk_absence_personnel1 (idpersonnel);

--
-- Index pour la table motif
--
ALTER TABLE motif
  ADD PRIMARY KEY (idmotif);

--
-- Index pour la table personnel
--
ALTER TABLE personnel
  ADD PRIMARY KEY (idpersonnel),
  ADD KEY i_fk_personnel_service1 (idservice);

--
-- Index pour la table service
--
ALTER TABLE service
  ADD PRIMARY KEY (idservice);

--
-- AUTO_INCREMENT pour les tables déchargées
--

--
-- AUTO_INCREMENT pour la table motif
--
ALTER TABLE motif
  MODIFY idmotif int NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- AUTO_INCREMENT pour la table personnel
--
ALTER TABLE personnel
  MODIFY idpersonnel int NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=16;

--
-- AUTO_INCREMENT pour la table service
--
ALTER TABLE service
  MODIFY idservice int NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
