-- phpMyAdmin SQL Dump
-- version 5.1.3
-- https://www.phpmyadmin.net/
--
-- Hôte : localhost:3306
-- Généré le : mer. 27 déc. 2023 à 17:48
-- Version du serveur : 5.7.33
-- Version de PHP : 7.4.19

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de données : `odcrestaurant`
--

-- --------------------------------------------------------

--
-- Structure de la table `categories`
--

CREATE TABLE `categories` (
  `id` int(11) NOT NULL,
  `nom` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Déchargement des données de la table `categories`
--

INSERT INTO `categories` (`id`, `nom`) VALUES
(7, 'Boisson'),
(6, 'Desserts'),
(5, 'Riz'),
(2, 'Sandwich');

-- --------------------------------------------------------

--
-- Structure de la table `clients`
--

CREATE TABLE `clients` (
  `id` int(5) NOT NULL,
  `nom` varchar(100) NOT NULL,
  `prenom` varchar(100) NOT NULL,
  `telephone` varchar(9) NOT NULL,
  `adresse` varchar(100) NOT NULL,
  `genre` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Déchargement des données de la table `clients`
--

INSERT INTO `clients` (`id`, `nom`, `prenom`, `telephone`, `adresse`, `genre`) VALUES
(1, 'BAH', 'Daouda', '623269097', 'Kakimbo - Ratoma Centre', 'Masculin'),
(6, 'BANGOURA', 'Souleymane', '623632311', 'Boulbinet - Kaloum', 'Masculin'),
(7, 'SOUMAH', 'Aboubacar', '664531394', 'Nongo taady - Ratoma', 'Masculin');

-- --------------------------------------------------------

--
-- Structure de la table `commande`
--

CREATE TABLE `commande` (
  `id` int(5) NOT NULL,
  `commandeId` varchar(100) NOT NULL,
  `montant` varchar(10) DEFAULT NULL,
  `idClient` int(5) NOT NULL,
  `status` varchar(100) DEFAULT NULL,
  `idUtilisateur` int(5) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Structure de la table `detaillecommande`
--

CREATE TABLE `detaillecommande` (
  `id` int(5) NOT NULL,
  `idCommande` int(5) NOT NULL,
  `idPlats` int(5) NOT NULL,
  `quantite` int(5) NOT NULL,
  `prix` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Structure de la table `ingredients`
--

CREATE TABLE `ingredients` (
  `id` int(5) NOT NULL,
  `ingredient` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Déchargement des données de la table `ingredients`
--

INSERT INTO `ingredients` (`id`, `ingredient`) VALUES
(10, 'Banane'),
(9, 'C'),
(1, 'Tomate');

-- --------------------------------------------------------

--
-- Structure de la table `ingredients_plats`
--

CREATE TABLE `ingredients_plats` (
  `id` int(5) NOT NULL,
  `idIngredients` int(5) DEFAULT NULL,
  `idPlat` int(5) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Structure de la table `menu`
--

CREATE TABLE `menu` (
  `id` int(5) NOT NULL,
  `nom` varchar(100) DEFAULT NULL,
  `description` text
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Structure de la table `produits`
--

CREATE TABLE `produits` (
  `id` int(5) NOT NULL,
  `designation` varchar(100) NOT NULL,
  `description` text,
  `prix` varchar(10) NOT NULL,
  `idCategorie` int(5) NOT NULL,
  `photo` blob
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Déchargement des données de la table `produits`
--

INSERT INTO `produits` (`id`, `designation`, `description`, `prix`, `idCategorie`, `photo`) VALUES
(1, 'Sandwich pain arabe', 'DDD', '20000', 2, 0x53797374656d2e427974655b5d),
(2, 'FFF', 'DDD', '40000', 2, 0x53797374656d2e427974655b5d),
(3, 'Vimto', 'Jus non gazeuse', '10000', 7, 0x53797374656d2e427974655b5d),
(4, 'Fruitalos Ananas', 'DD', '15000', 7, 0x53797374656d2e427974655b5d),
(7, 'Fruitalos Orange', 'DD', '44555', 7, 0x53797374656d2e427974655b5d);

-- --------------------------------------------------------

--
-- Structure de la table `role`
--

CREATE TABLE `role` (
  `id` int(11) NOT NULL,
  `role` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Déchargement des données de la table `role`
--

INSERT INTO `role` (`id`, `role`) VALUES
(1, 'Admin'),
(2, 'Gerant'),
(3, 'Cuisinier');

-- --------------------------------------------------------

--
-- Structure de la table `tables`
--

CREATE TABLE `tables` (
  `id` int(11) NOT NULL,
  `table` varchar(100) NOT NULL,
  `places` int(11) NOT NULL,
  `disponible` varchar(50) NOT NULL DEFAULT 'disponible'
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Déchargement des données de la table `tables`
--

INSERT INTO `tables` (`id`, `table`, `places`, `disponible`) VALUES
(1, 'VIP TOP', 3, 'disponible'),
(3, 'KALOUM 1', 2, 'disponible');

-- --------------------------------------------------------

--
-- Structure de la table `utilisateur`
--

CREATE TABLE `utilisateur` (
  `id` int(11) NOT NULL,
  `nom` varchar(100) NOT NULL,
  `telephone` varchar(15) NOT NULL,
  `adresse` varchar(100) NOT NULL,
  `password` varchar(250) NOT NULL,
  `role` varchar(20) NOT NULL,
  `status` varchar(10) NOT NULL DEFAULT 'non'
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Déchargement des données de la table `utilisateur`
--

INSERT INTO `utilisateur` (`id`, `nom`, `telephone`, `adresse`, `password`, `role`, `status`) VALUES
(1, 'Daouda Bah', '623269097', 'Bowoye', '0765603E17BE52C7381F80520BDB3088', 'Admin', 'oui'),
(13, 'Fanta Nabe', '623632310', 'Gbessia', '827CCB0EEA8A706C4C34A16891F84E7B', 'Gerant', 'non');

--
-- Index pour les tables déchargées
--

--
-- Index pour la table `categories`
--
ALTER TABLE `categories`
  ADD PRIMARY KEY (`id`),
  ADD UNIQUE KEY `nom` (`nom`);

--
-- Index pour la table `clients`
--
ALTER TABLE `clients`
  ADD PRIMARY KEY (`id`),
  ADD UNIQUE KEY `telephone` (`telephone`);

--
-- Index pour la table `commande`
--
ALTER TABLE `commande`
  ADD PRIMARY KEY (`id`),
  ADD UNIQUE KEY `CmdId` (`commandeId`),
  ADD KEY `Client_Commande` (`idClient`),
  ADD KEY `commande_utilisateur` (`idUtilisateur`);

--
-- Index pour la table `detaillecommande`
--
ALTER TABLE `detaillecommande`
  ADD KEY `commande` (`idCommande`),
  ADD KEY `plat` (`idPlats`);

--
-- Index pour la table `ingredients`
--
ALTER TABLE `ingredients`
  ADD PRIMARY KEY (`id`),
  ADD UNIQUE KEY `nom` (`ingredient`),
  ADD UNIQUE KEY `ingredient` (`ingredient`);

--
-- Index pour la table `ingredients_plats`
--
ALTER TABLE `ingredients_plats`
  ADD KEY `ingredient` (`idIngredients`),
  ADD KEY `plat_ingredient` (`idPlat`);

--
-- Index pour la table `menu`
--
ALTER TABLE `menu`
  ADD PRIMARY KEY (`id`);

--
-- Index pour la table `produits`
--
ALTER TABLE `produits`
  ADD PRIMARY KEY (`id`),
  ADD UNIQUE KEY `nom` (`designation`),
  ADD UNIQUE KEY `designation` (`designation`),
  ADD KEY `idCategorie` (`idCategorie`);

--
-- Index pour la table `role`
--
ALTER TABLE `role`
  ADD PRIMARY KEY (`id`);

--
-- Index pour la table `tables`
--
ALTER TABLE `tables`
  ADD PRIMARY KEY (`id`),
  ADD UNIQUE KEY `nom` (`table`);

--
-- Index pour la table `utilisateur`
--
ALTER TABLE `utilisateur`
  ADD PRIMARY KEY (`id`),
  ADD UNIQUE KEY `telephone` (`telephone`);

--
-- AUTO_INCREMENT pour les tables déchargées
--

--
-- AUTO_INCREMENT pour la table `categories`
--
ALTER TABLE `categories`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=8;

--
-- AUTO_INCREMENT pour la table `clients`
--
ALTER TABLE `clients`
  MODIFY `id` int(5) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=8;

--
-- AUTO_INCREMENT pour la table `commande`
--
ALTER TABLE `commande`
  MODIFY `id` int(5) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT pour la table `ingredients`
--
ALTER TABLE `ingredients`
  MODIFY `id` int(5) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=11;

--
-- AUTO_INCREMENT pour la table `produits`
--
ALTER TABLE `produits`
  MODIFY `id` int(5) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=8;

--
-- AUTO_INCREMENT pour la table `role`
--
ALTER TABLE `role`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT pour la table `tables`
--
ALTER TABLE `tables`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT pour la table `utilisateur`
--
ALTER TABLE `utilisateur`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=14;

--
-- Contraintes pour les tables déchargées
--

--
-- Contraintes pour la table `commande`
--
ALTER TABLE `commande`
  ADD CONSTRAINT `Client_Commande` FOREIGN KEY (`idClient`) REFERENCES `clients` (`id`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `commande_utilisateur` FOREIGN KEY (`idUtilisateur`) REFERENCES `utilisateur` (`id`);

--
-- Contraintes pour la table `detaillecommande`
--
ALTER TABLE `detaillecommande`
  ADD CONSTRAINT `commande` FOREIGN KEY (`idCommande`) REFERENCES `commande` (`id`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Contraintes pour la table `ingredients_plats`
--
ALTER TABLE `ingredients_plats`
  ADD CONSTRAINT `ingredient` FOREIGN KEY (`idIngredients`) REFERENCES `ingredients` (`id`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Contraintes pour la table `produits`
--
ALTER TABLE `produits`
  ADD CONSTRAINT `categorie_plat` FOREIGN KEY (`idCategorie`) REFERENCES `categories` (`id`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
